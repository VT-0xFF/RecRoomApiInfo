using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class CNMLCIBLBGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Vector3 MGGNICOGCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Quaternion KDPJNNPKKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Vector3 MMJLCJLFEHK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6EE3A40", Offset = "0x6EE2240", VA = "0x186EE3A40")]
	public bool OFEANHELAJH(Collider JNLMKMJDNIN, ref Bounds NDJAACEKCOK, bool IBIHFOPJBFN, bool EELJAJFOCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6EE29C0", Offset = "0x6EE11C0", VA = "0x186EE29C0")]
	public bool HBLBEILGCGI(Collider CKEDCDKNDCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6EE29E0", Offset = "0x6EE11E0", VA = "0x186EE29E0")]
	public bool IJDICIONOCH(Collider CKEDCDKNDCL, bool IBIHFOPJBFN, bool EELJAJFOCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2F40", Offset = "0x6EE1740", VA = "0x186EE2F40")]
	public void NBJIMFNGCJF(CNMLCIBLBGH MDHJAFNLPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2E10", Offset = "0x6EE1610", VA = "0x186EE2E10")]
	private static void MMDGNIKHGIN(ref Vector3 FAFCDNENBCM, ref Vector3 LDBGNHOKNMO, Vector3 NFCEBNNOPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6EE25B0", Offset = "0x6EE0DB0", VA = "0x186EE25B0")]
	public static CNMLCIBLBGH CBENCBAELKC(GameObject PMBNHDHBMIA, Quaternion KDPJNNPKKHC, bool NIIBMIPCAIP, bool IEGCJKDPECE, bool IBIHFOPJBFN = false, bool EELJAJFOCLO = false, bool IGPNOKMANEM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public CNMLCIBLBGH()
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x3C60AF0", Offset = "0x3C5F2F0", VA = "0x183C60AF0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6EEA230", Offset = "0x6EE8A30", VA = "0x186EEA230")]
		public SerializedGuid(in Guid PCFHAIHNKAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6EEA200", Offset = "0x6EE8A00", VA = "0x186EEA200", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6EEA160", Offset = "0x6EE8960", VA = "0x186EEA160", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6EEA0A0", Offset = "0x6EE88A0", VA = "0x186EEA0A0", Slot = "7")]
		public bool Equals(SerializedGuid MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9FC0", Offset = "0x6EE87C0", VA = "0x186EE9FC0", Slot = "0")]
		public override bool Equals(object HHNPCHNMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6EEA150", Offset = "0x6EE8950", VA = "0x186EEA150", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9F90", Offset = "0x6EE8790", VA = "0x186EE9F90", Slot = "6")]
		public int CompareTo(SerializedGuid MDHJAFNLPON)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecRoomAudioClipRegistryAsset : RecRoomStudioBuildAsset<RecRoomAudioClipRegistryAsset>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		internal RecRoomAudioClipEntry[] clips;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public IReadOnlyList<RecRoomAudioClipEntry> Clips
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6EE6DC0", Offset = "0x6EE55C0", VA = "0x186EE6DC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6D80", Offset = "0x6EE5580", VA = "0x186EE6D80")]
		public RecRoomAudioClipRegistryAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class RecRoomAudioClipEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AudioClip Clip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public RecRoomAudioClipEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class RecRoomObjectPrefabRegistryAsset : RecRoomStudioBuildAsset<RecRoomObjectPrefabRegistryAsset>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private RecRoomObjectPrefabEntry[] prefabs;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public RecRoomObjectPrefabEntry[] Prefabs
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6EE87A0", Offset = "0x6EE6FA0", VA = "0x186EE87A0")]
		public RecRoomObjectPrefabRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[RequireComponent(typeof(Canvas))]
	public class RecRoomStudioHudCanvas : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9080F0", Offset = "0x9068F0", VA = "0x1809080F0")]
		public RecRoomStudioHudCanvas()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[AddComponentMenu("")]
	public sealed class RecRoomObjectPrefabRegistry : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static RecRoomObjectPrefabRegistry PKIKEDNMDGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[HideInInspector]
		[SerializeField]
		private RecRoomObjectPrefabEntry[] prefabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		private RecRoomObjectPrefabRegistryAsset prefabsAsset;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static RecRoomObjectPrefabRegistry EABDDJEADPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8AA0", Offset = "0x6EE72A0", VA = "0x186EE8AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IReadOnlyList<RecRoomObjectPrefabEntry> JJOFMKIDLJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8A00", Offset = "0x6EE7200", VA = "0x186EE8A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6EE87E0", Offset = "0x6EE6FE0", VA = "0x186EE87E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6EE88D0", Offset = "0x6EE70D0", VA = "0x186EE88D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9080F0", Offset = "0x9068F0", VA = "0x1809080F0")]
		public RecRoomObjectPrefabRegistry()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RecRoomObjectPrefabEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public RecRoomObject Prefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public RecRoomObjectPrefabEntry()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Field)]
public class GDMGCFENDJO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE43E0", Offset = "0x6EE2BE0", VA = "0x186EE43E0")]
	public GDMGCFENDJO(string OHNDBNDIBPN, bool NGIPOINNIKM, string LFKDAEHCEJE)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[AddComponentMenu("")]
	public sealed class RecRoomAudioClipRegistry : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static RecRoomAudioClipRegistry PKIKEDNMDGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private RecRoomAudioClipRegistryAsset entriesAsset;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static RecRoomAudioClipRegistry EABDDJEADPB
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6EE70F0", Offset = "0x6EE58F0", VA = "0x186EE70F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RecRoomAudioClipRegistryAsset FOLGAHKDHAH
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IReadOnlyList<RecRoomAudioClipEntry> BLFEJBCFHGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6EE7030", Offset = "0x6EE5830", VA = "0x186EE7030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6E10", Offset = "0x6EE5610", VA = "0x186EE6E10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6F00", Offset = "0x6EE5700", VA = "0x186EE6F00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9080F0", Offset = "0x9068F0", VA = "0x1809080F0")]
		public RecRoomAudioClipRegistry()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Class)]
public class LLFFNNJONGA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x80EA90", Offset = "0x80D290", VA = "0x18080EA90")]
	public LLFFNNJONGA()
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class RecRoomBuiltInObjectData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private RecRoomBuiltInObject[] builtInObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Dictionary<Guid, RecRoomBuiltInObject> lookup;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private Dictionary<Guid, RecRoomBuiltInObject> Lookup
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8420", Offset = "0x6EE6C20", VA = "0x186EE8420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IReadOnlyDictionary<Guid, RecRoomBuiltInObject> AllBuiltInObjects
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8410", Offset = "0x6EE6C10", VA = "0x186EE8410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6EE83A0", Offset = "0x6EE6BA0", VA = "0x186EE83A0")]
		public void OFPCJGALLLL(IEnumerable<RecRoomBuiltInObject> JMKGALAJEFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8320", Offset = "0x6EE6B20", VA = "0x186EE8320")]
		public bool KFBGNHHGLGM(Guid NHGBINLAEMM, out RecRoomBuiltInObject JFCFFHLAPFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xBBBD50", Offset = "0xBBA550", VA = "0x180BBBD50")]
		public RecRoomBuiltInObjectData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum NKAJKMNFNMI
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Prop,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Gadget
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[AddComponentMenu("")]
	public class MaterialMap : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public class TextureProperty
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public Texture value;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public class FloatProperty
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public float value;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public class VectorProperty
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public Vector4 value;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public class ColorProperty
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Color value;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public class MaterialEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Material material;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public string shaderName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public MaterialGlobalIlluminationFlags globalIlluminationFlags;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public int renderQueue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public bool doubleSidedGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public TextureProperty[] texProps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public FloatProperty[] floatProps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public VectorProperty[] vecProps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public ColorProperty[] colorProps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private Dictionary<string, float> floatPropsDict;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private Dictionary<int, float> floatPropIdDict;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private Dictionary<int, Texture> texPropIdDict;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private Dictionary<int, Vector4> vecPropIdDict;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private Dictionary<int, Color> colorPropIdDict;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6EE4E10", Offset = "0x6EE3610", VA = "0x186EE4E10")]
			public void BDGJDDLMFKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6EE53A0", Offset = "0x6EE3BA0", VA = "0x186EE53A0")]
			public float CDACDHEBJOE(string BPOKAAOBIOI)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5330", Offset = "0x6EE3B30", VA = "0x186EE5330")]
			public float CDACDHEBJOE(int AOGGNHKFEEF)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6EE54A0", Offset = "0x6EE3CA0", VA = "0x186EE54A0")]
			public Texture KNKABLNJOOH(int AOGGNHKFEEF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5510", Offset = "0x6EE3D10", VA = "0x186EE5510")]
			public Vector4 OGKMCDMNIKB(int AOGGNHKFEEF)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5410", Offset = "0x6EE3C10", VA = "0x186EE5410")]
			public Color GPMAGCBLLOA(int AOGGNHKFEEF)
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static MaterialMap PKIKEDNMDGD;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<MaterialEntry> NLHOPMLKPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		[HideInInspector]
		private MaterialEntry[] entries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private MaterialMapAsset entriesAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Dictionary<Material, MaterialEntry> OMCJJBCHFCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private HashSet<Material> KDOFJAJHLMA;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static MaterialMap EABDDJEADPB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5B90", Offset = "0x6EE4390", VA = "0x186EE5B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MaterialEntry[] FOLGAHKDHAH
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5B00", Offset = "0x6EE4300", VA = "0x186EE5B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE55E0", Offset = "0x6EE3DE0", VA = "0x186EE55E0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5A60", Offset = "0x6EE4260", VA = "0x186EE5A60")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6EE59F0", Offset = "0x6EE41F0", VA = "0x186EE59F0")]
		public MaterialEntry GetEntryForMaterial(Material LKBAOCKJBBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5850", Offset = "0x6EE4050", VA = "0x186EE5850")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9080F0", Offset = "0x9068F0", VA = "0x1809080F0")]
		public MaterialMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[AddComponentMenu("")]
	public sealed class RecRoomAudioMixerRegistry : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public enum LHFBPAKDFLJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			SeparateMixers,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			SingleMixer
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public enum OIOPDEPJBNJ
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			Ambience,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			Music,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			Sounds,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			Voice,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			Voice_LowPitch,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			Voice_HighPitch,
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			Voice_Radio,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			Voice_Radio_LowPitch,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			Voice_Radio_HighPitch
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly Dictionary<OIOPDEPJBNJ, string> GBCKGNPHOBI;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const string MusicName = "Music";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const string AmbienceName = "Ambience";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string SoundsName = "Sounds";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const string HLBHEMCDPML = "Assets";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private const string DKKHJCOPNDH = "RecRoomStudio";

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const string HFGJKMOOOEO = "Audio";

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly string BKHCEPDJEJE;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static readonly string KAJMFPOCNBA;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static RecRoomAudioMixerRegistry PKIKEDNMDGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		[LOJIIEDMHCC]
		private LHFBPAKDFLJ version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		[AOGHOAAELNP("version", 0, false)]
		private AudioMixer music;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		[AOGHOAAELNP("version", 0, false)]
		private AudioMixer ambience;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		[AOGHOAAELNP("version", 0, false)]
		private AudioMixer sounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		[AOGHOAAELNP("version", 1, false)]
		private AudioMixer studioMixer;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static RecRoomAudioMixerRegistry EABDDJEADPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6EE80A0", Offset = "0x6EE68A0", VA = "0x186EE80A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public AudioMixer GBAMHAGMIME
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7F3660", Offset = "0x7F1E60", VA = "0x1807F3660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool GLGGKOPKDGG
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8100", Offset = "0x6EE6900", VA = "0x186EE8100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public LHFBPAKDFLJ ODKLBHBAMKF
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8AD980", Offset = "0x8AC180", VA = "0x1808AD980")]
			get
			{
				return default(LHFBPAKDFLJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8270", Offset = "0x6EE6A70", VA = "0x186EE8270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE73F0", Offset = "0x6EE5BF0", VA = "0x186EE73F0")]
		public static string GetAudioGroupPath(OIOPDEPJBNJ LKDCOALNLMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7510", Offset = "0x6EE5D10", VA = "0x186EE7510")]
		public AudioMixerGroup GetMixerGroup(OIOPDEPJBNJ LKDCOALNLMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7BE0", Offset = "0x6EE63E0", VA = "0x186EE7BE0")]
		private static AudioMixerGroup LMDIJIKACPM(AudioMixer CMAJFKKMENE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7130", Offset = "0x6EE5930", VA = "0x186EE7130")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7C90", Offset = "0x6EE6490", VA = "0x186EE7C90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7700", Offset = "0x6EE5F00", VA = "0x186EE7700")]
		public bool IsValidOutputGroup(AudioMixerGroup KEGGKGCFPHE, out string FKPBDLDGFCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7260", Offset = "0x6EE5A60", VA = "0x186EE7260")]
		private bool DFGGHFNOLFG(AudioMixerGroup KEGGKGCFPHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7960", Offset = "0x6EE6160", VA = "0x186EE7960")]
		private bool LHBDMHGNGLP(AudioMixerGroup HJEJDAIAKEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9080F0", Offset = "0x9068F0", VA = "0x1809080F0")]
		public RecRoomAudioMixerRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[RequireComponent(typeof(Canvas))]
	public sealed class RecRoomStudioCanvasInteraction : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		[Tooltip("Allows the player to interact with elements on the canvas directly")]
		private bool isInteractable;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool GLOAGIJGDPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8C7730", Offset = "0x8C5F30", VA = "0x1808C7730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x14DF030", Offset = "0x14DD830", VA = "0x1814DF030")]
		public RecRoomStudioCanvasInteraction()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface ABBMGKBPMJE
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	AudioMixerGroup PEEGHFFGLCD
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	ABBMGKBPMJE PANFGPHKOIE
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IReadOnlyList<ABBMGKBPMJE> GLGFKAIAEPC
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string HFMMEACKMFL
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LKEHCMNIIMM
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class GBNJPIAONBC : ABBMGKBPMJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal readonly List<ABBMGKBPMJE> MKLCAJEOMIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal readonly GBNJPIAONBC LBJKLBDOFKF;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public ABBMGKBPMJE PANFGPHKOIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public AudioMixerGroup PEEGHFFGLCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8ACF00", Offset = "0x8AB700", VA = "0x1808ACF00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<ABBMGKBPMJE> GLGFKAIAEPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string HFMMEACKMFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CE0", Offset = "0x7F14E0", VA = "0x1807F2CE0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6EE42D0", Offset = "0x6EE2AD0", VA = "0x186EE42D0")]
		internal GBNJPIAONBC(AudioMixerGroup JDPPDHMPNHH, GBNJPIAONBC ONIJEEBBCHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CE0", Offset = "0x7F14E0", VA = "0x1807F2CE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ABBMGKBPMJE PJIGEHEGJNA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public AudioMixer HOPJLOBCHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4790", Offset = "0x6EE2F90", VA = "0x186EE4790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8ACD20", Offset = "0x8AB520", VA = "0x1808ACD20")]
	private LKEHCMNIIMM(GBNJPIAONBC GJJMPNCPDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4490", Offset = "0x6EE2C90", VA = "0x186EE4490")]
	public static LKEHCMNIIMM ADAGABIFJHF(AudioMixer CMAJFKKMENE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4870", Offset = "0x6EE3070", VA = "0x186EE4870")]
	public ABBMGKBPMJE MIBMELALCEG(string BNKAOMBODPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4BD0", Offset = "0x6EE33D0", VA = "0x186EE4BD0")]
	public ABBMGKBPMJE MIBMELALCEG(AudioMixerGroup JDPPDHMPNHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6EE47F0", Offset = "0x6EE2FF0", VA = "0x186EE47F0")]
	private static int JFKLIAPDMLN(string FMALCPACLGP, int DBEIIGKEBIB)
	{
		return default(int);
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[AddComponentMenu("")]
	public sealed class RecRoomVisualPostProcessing : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		public VolumeProfile PostProcessingProfile;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static RecRoomVisualPostProcessing PKIKEDNMDGD;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RecRoomVisualPostProcessing EABDDJEADPB
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6EE9F50", Offset = "0x6EE8750", VA = "0x186EE9F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9D10", Offset = "0x6EE8510", VA = "0x186EE9D10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9E00", Offset = "0x6EE8600", VA = "0x186EE9E00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9080F0", Offset = "0x9068F0", VA = "0x1809080F0")]
		public RecRoomVisualPostProcessing()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public sealed class RecRoomObjectProperty
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			Hide
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private string propertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private RecRoomObjectPropertyAccessor propertyAccessor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private BoardConfig boardConfig;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string PropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x58ECD30", Offset = "0x58EB530", VA = "0x1858ECD30")]
		public bool KFBGNHHGLGM<T>(out T ECNGHFJBIJL, out string FKPBDLDGFCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8CC0", Offset = "0x6EE74C0", VA = "0x186EE8CC0")]
		public static string PLOKAPHGDPO(Type NFOHJNABMAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public RecRoomObjectProperty()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[AddComponentMenu("")]
	public class RecRoomBuiltInObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[HideInInspector]
		[SerializeField]
		private SerializedGuid prefabId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		[LOJIIEDMHCC]
		private string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[LOJIIEDMHCC]
		[SerializeField]
		private NKAJKMNFNMI category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		[HideInInspector]
		private byte[] spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		[LOJIIEDMHCC]
		private bool availableInMakerPen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[SerializeField]
		[LOJIIEDMHCC]
		private bool isBetaItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[HideInInspector]
		[SerializeField]
		private bool availableToDevsOnly;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Guid OLEFDADEIAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8670", Offset = "0x6EE6E70", VA = "0x186EE8670")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8710", Offset = "0x6EE6F10", VA = "0x186EE8710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string HFLCPAHPIIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8ACF00", Offset = "0x8AB700", VA = "0x1808ACF00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8ACF10", Offset = "0x8AB710", VA = "0x1808ACF10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public NKAJKMNFNMI ADEBPOJNONJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8CEF90", Offset = "0x8CD790", VA = "0x1808CEF90")]
			get
			{
				return default(NKAJKMNFNMI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA5F890", Offset = "0xA5E090", VA = "0x180A5F890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool DKIIGBPNIHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9FBE30", Offset = "0x9FA630", VA = "0x1809FBE30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xC30FC0", Offset = "0xC2F7C0", VA = "0x180C30FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool JECDIPOLAMF
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xCB1E30", Offset = "0xCB0630", VA = "0x180CB1E30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xF9EE00", Offset = "0xF9D600", VA = "0x180F9EE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool PIGEJFHEBIE
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x15EFCF0", Offset = "0x15EE4F0", VA = "0x1815EFCF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x15F03A0", Offset = "0x15EEBA0", VA = "0x1815F03A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CHHHCPOKMKL
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8650", Offset = "0x6EE6E50", VA = "0x186EE8650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool MPMIOOPBFIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8600", Offset = "0x6EE6E00", VA = "0x186EE8600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6EE85C0", Offset = "0x6EE6DC0", VA = "0x186EE85C0")]
		public byte[] GetSpawnableTemplateDataCopy()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x919F90", Offset = "0x918790", VA = "0x180919F90")]
		public void SetSpawnableTemplateData(byte[] HPDIEPCDDNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x91EC60", Offset = "0x91D460", VA = "0x18091EC60")]
		public void ClearSpawnableTemplateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9080F0", Offset = "0x9068F0", VA = "0x1809080F0")]
		public RecRoomBuiltInObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RecRoomStudioBuildAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2CBB510", Offset = "0x2CB9D10", VA = "0x182CBB510")]
		public RecRoomStudioBuildAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[DisallowMultipleComponent]
	[LLFFNNJONGA]
	[AddComponentMenu("Rec Room Studio/Rec Room Object")]
	public sealed class RecRoomObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class <GetEventsWithName>d__26 : IEnumerable<NamedUnityEventBase>, IEnumerable, IEnumerator<NamedUnityEventBase>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private NamedUnityEventBase <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private string eventName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public string <>3__eventName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public RecRoomObject <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private NamedUnityEventBase[] <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private int <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private NamedUnityEventBase <e>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			NamedUnityEventBase IEnumerator<NamedUnityEventBase>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xB955D0", Offset = "0xB93DD0", VA = "0x180B955D0")]
			[DebuggerHidden]
			public <GetEventsWithName>d__26(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6EEA260", Offset = "0x6EE8A60", VA = "0x186EEA260", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6EEA430", Offset = "0x6EE8C30", VA = "0x186EEA430", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6EEA380", Offset = "0x6EE8B80", VA = "0x186EEA380", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<NamedUnityEventBase> IEnumerable<NamedUnityEventBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x6EEA380", Offset = "0x6EE8B80", VA = "0x186EEA380", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private RecRoomObjectConfiguration defaultConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[HideInInspector]
		[SerializeField]
		internal RecRoomObjectProperty[] properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[HideInInspector]
		[SerializeReference]
		internal NamedUnityEventBase[] unityEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Dictionary<string, RecRoomObjectProperty> propertyLookup;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RecRoomObjectProperty[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8ACF00", Offset = "0x8AB700", VA = "0x1808ACF00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public NamedUnityEventBase[] UnityEvents
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CE0", Offset = "0x7F14E0", VA = "0x1807F2CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public RecRoomObjectConfiguration DefaultConfiguration
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6EE9B70", Offset = "0x6EE8370", VA = "0x186EE9B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<RecRoomObject, string> OnSendCircuitsEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6EE9AD0", Offset = "0x6EE82D0", VA = "0x186EE9AD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6EE9BF0", Offset = "0x6EE83F0", VA = "0x186EE9BF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8F60", Offset = "0x6EE7760", VA = "0x186EE8F60")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9210", Offset = "0x6EE7A10", VA = "0x186EE9210")]
		public bool TryGetProperty(string propertyName, out RecRoomObjectProperty property)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE94D0", Offset = "0x6EE7CD0", VA = "0x186EE94D0")]
		public bool TryRaiseUnityEvent(string eventName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8FF0", Offset = "0x6EE77F0", VA = "0x186EE8FF0")]
		public void SendCircuitsEvent(string eventName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x58EEB40", Offset = "0x58ED340", VA = "0x1858EEB40")]
		private bool TryRaiseUnityEvent<T0, T1, TEvent>(string eventName, T0 value0, T1 value1) where TEvent : UnityEvent<T0, T1>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9830", Offset = "0x6EE8030", VA = "0x186EE9830")]
		public bool TryRaiseUnityEvent(string eventName, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6EE99F0", Offset = "0x6EE81F0", VA = "0x186EE99F0")]
		public bool TryRaiseUnityEvent(string eventName, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9670", Offset = "0x6EE7E70", VA = "0x186EE9670")]
		public bool TryRaiseUnityEvent(string eventName, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6EE93F0", Offset = "0x6EE7BF0", VA = "0x186EE93F0")]
		public bool TryRaiseUnityEvent(string eventName, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9910", Offset = "0x6EE8110", VA = "0x186EE9910")]
		public bool TryRaiseUnityEvent(string eventName, string value0, bool value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6EE97C0", Offset = "0x6EE7FC0", VA = "0x186EE97C0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, float value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9750", Offset = "0x6EE7F50", VA = "0x186EE9750")]
		public bool TryRaiseUnityEvent(string eventName, string value0, int value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9980", Offset = "0x6EE8180", VA = "0x186EE9980")]
		public bool TryRaiseUnityEvent(string eventName, string value0, string value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8ED0", Offset = "0x6EE76D0", VA = "0x186EE8ED0")]
		[IteratorStateMachine(typeof(<GetEventsWithName>d__26))]
		private IEnumerable<NamedUnityEventBase> GetEventsWithName(string eventName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9050", Offset = "0x6EE7850", VA = "0x186EE9050")]
		private bool TryFindAndInvoke(string eventName, Func<NamedUnityEventBase, bool> invoke)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9080F0", Offset = "0x9068F0", VA = "0x1809080F0")]
		public RecRoomObject()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public abstract class NamedUnityEventBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		private string eventName;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void InvokeEvent();

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7F35F0", Offset = "0x7F1DF0", VA = "0x1807F35F0", Slot = "5")]
		public virtual bool TryInvokeEvent(bool ECNGHFJBIJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7F35F0", Offset = "0x7F1DF0", VA = "0x1807F35F0", Slot = "6")]
		public virtual bool TryInvokeEvent(float ECNGHFJBIJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7F35F0", Offset = "0x7F1DF0", VA = "0x1807F35F0", Slot = "7")]
		public virtual bool TryInvokeEvent(int ECNGHFJBIJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7F35F0", Offset = "0x7F1DF0", VA = "0x1807F35F0", Slot = "8")]
		public virtual bool TryInvokeEvent(string ECNGHFJBIJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public abstract class NamedUnityEventBase<TUnityEvent> : NamedUnityEventBase where TUnityEvent : UnityEventBase, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		private TUnityEvent unityEvent;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public TUnityEvent Event
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x453C0A0", Offset = "0x453A8A0", VA = "0x18453C0A0")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class UnityBooleanEvent : UnityEvent<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6EEA660", Offset = "0x6EE8E60", VA = "0x186EEA660")]
		public UnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public sealed class UnityFloatEvent : UnityEvent<float>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6EEA6A0", Offset = "0x6EE8EA0", VA = "0x186EEA6A0")]
		public UnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class UnityIntEvent : UnityEvent<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6EEA6E0", Offset = "0x6EE8EE0", VA = "0x186EEA6E0")]
		public UnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public sealed class UnityStringEvent : UnityEvent<string>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6EEA760", Offset = "0x6EE8F60", VA = "0x186EEA760")]
		public UnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class UnityStringBooleanEvent : UnityEvent<string, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6EEA720", Offset = "0x6EE8F20", VA = "0x186EEA720")]
		public UnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class UnityStringIntEvent : UnityEvent<string, int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6EEA7E0", Offset = "0x6EE8FE0", VA = "0x186EEA7E0")]
		public UnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class UnityStringFloatEvent : UnityEvent<string, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6EEA7A0", Offset = "0x6EE8FA0", VA = "0x186EEA7A0")]
		public UnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class UnityStringStringEvent : UnityEvent<string, string>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6EEA820", Offset = "0x6EE9020", VA = "0x186EEA820")]
		public UnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[Preserve]
	[LLFFNNJONGA]
	public sealed class NamedUnityEvent : NamedUnityEventBase<UnityEvent>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			Hide
		}

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5DD0", Offset = "0x6EE45D0", VA = "0x186EE5DD0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5E90", Offset = "0x6EE4690", VA = "0x186EE5E90")]
		public NamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[LLFFNNJONGA]
	[Preserve]
	public abstract class OneParamNamedUnityEvent<TUnityEvent> : NamedUnityEventBase<TUnityEvent> where TUnityEvent : UnityEventBase, new()
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			Hide,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			HideParam
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1B7C270", Offset = "0x1B7AA70", VA = "0x181B7C270")]
		protected OneParamNamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[LLFFNNJONGA]
	[Preserve]
	public abstract class TwoParamNamedUnityEvent<TUnityEvent> : NamedUnityEventBase<TUnityEvent> where TUnityEvent : UnityEventBase, new()
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			Hide,
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			HideParam1,
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			HideBothParams
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		protected string defaultValue1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1B7C270", Offset = "0x1B7AA70", VA = "0x181B7C270")]
		protected TwoParamNamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[LLFFNNJONGA]
	[Preserve]
	public sealed class NamedUnityBooleanEvent : OneParamNamedUnityEvent<UnityBooleanEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		private bool defaultValue;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5BD0", Offset = "0x6EE43D0", VA = "0x186EE5BD0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5C30", Offset = "0x6EE4430", VA = "0x186EE5C30", Slot = "5")]
		public override bool TryInvokeEvent(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5D90", Offset = "0x6EE4590", VA = "0x186EE5D90")]
		public NamedUnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[Preserve]
	[LLFFNNJONGA]
	public sealed class NamedUnityFloatEvent : OneParamNamedUnityEvent<UnityFloatEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private float defaultValue;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5ED0", Offset = "0x6EE46D0", VA = "0x186EE5ED0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5F30", Offset = "0x6EE4730", VA = "0x186EE5F30", Slot = "6")]
		public override bool TryInvokeEvent(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6090", Offset = "0x6EE4890", VA = "0x186EE6090")]
		public NamedUnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[Preserve]
	[LLFFNNJONGA]
	public sealed class NamedUnityIntEvent : OneParamNamedUnityEvent<UnityIntEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private int defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6EE60D0", Offset = "0x6EE48D0", VA = "0x186EE60D0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6130", Offset = "0x6EE4930", VA = "0x186EE6130", Slot = "7")]
		public override bool TryInvokeEvent(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6290", Offset = "0x6EE4A90", VA = "0x186EE6290")]
		public NamedUnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[Preserve]
	[LLFFNNJONGA]
	public sealed class NamedUnityStringEvent : OneParamNamedUnityEvent<UnityStringEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private string defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6500", Offset = "0x6EE4D00", VA = "0x186EE6500", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6560", Offset = "0x6EE4D60", VA = "0x186EE6560", Slot = "8")]
		public override bool TryInvokeEvent(string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6EE66C0", Offset = "0x6EE4EC0", VA = "0x186EE66C0")]
		public NamedUnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[Preserve]
	[LLFFNNJONGA]
	public sealed class NamedUnityStringBooleanEvent : TwoParamNamedUnityEvent<UnityStringBooleanEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		private bool defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6EE62D0", Offset = "0x6EE4AD0", VA = "0x186EE62D0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6330", Offset = "0x6EE4B30", VA = "0x186EE6330", Slot = "5")]
		public override bool TryInvokeEvent(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6EE64C0", Offset = "0x6EE4CC0", VA = "0x186EE64C0")]
		public NamedUnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[Preserve]
	[LLFFNNJONGA]
	public sealed class NamedUnityStringFloatEvent : TwoParamNamedUnityEvent<UnityStringFloatEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private float defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6700", Offset = "0x6EE4F00", VA = "0x186EE6700", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6760", Offset = "0x6EE4F60", VA = "0x186EE6760", Slot = "6")]
		public override bool TryInvokeEvent(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6EE68F0", Offset = "0x6EE50F0", VA = "0x186EE68F0")]
		public NamedUnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[LLFFNNJONGA]
	[Preserve]
	public sealed class NamedUnityStringIntEvent : TwoParamNamedUnityEvent<UnityStringIntEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		private int defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6930", Offset = "0x6EE5130", VA = "0x186EE6930", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6990", Offset = "0x6EE5190", VA = "0x186EE6990", Slot = "7")]
		public override bool TryInvokeEvent(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6B20", Offset = "0x6EE5320", VA = "0x186EE6B20")]
		public NamedUnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[Preserve]
	[LLFFNNJONGA]
	public sealed class NamedUnityStringStringEvent : TwoParamNamedUnityEvent<UnityStringStringEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SerializeField]
		private string defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6B60", Offset = "0x6EE5360", VA = "0x186EE6B60", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6BC0", Offset = "0x6EE53C0", VA = "0x186EE6BC0", Slot = "8")]
		public override bool TryInvokeEvent(string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6D40", Offset = "0x6EE5540", VA = "0x186EE6D40")]
		public NamedUnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class RecRoomObjectPropertyAccessor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public UnityEngine.Object target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public string targetAssemblyTypeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public string propertyMethodName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private MethodInfo cachedTargetMethod;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private string FormattedPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8C50", Offset = "0x6EE7450", VA = "0x186EE8C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8BE0", Offset = "0x6EE73E0", VA = "0x186EE8BE0")]
		public MethodInfo LPCLAELBKLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8AE0", Offset = "0x6EE72E0", VA = "0x186EE8AE0")]
		public string LCAJKKODJEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public RecRoomObjectPropertyAccessor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct MHNGHFOJBBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public byte[] OECCIMIKFOA;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0xB91230", Offset = "0xB8FA30", VA = "0x180B91230")]
	public MHNGHFOJBBP(byte[] MEKBNGFFPML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct NGOHLNDOJLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public byte[] OECCIMIKFOA;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0xB91230", Offset = "0xB8FA30", VA = "0x180B91230")]
	public NGOHLNDOJLJ(byte[] MEKBNGFFPML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class EBCNOLGPJAF
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6EE3F60", Offset = "0x6EE2760", VA = "0x186EE3F60")]
	public static (MHNGHFOJBBP, NGOHLNDOJLJ) HPGHBGHJKCI(Stream NEOJHOCIJKI)
	{
		return default((MHNGHFOJBBP, NGOHLNDOJLJ));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4120", Offset = "0x6EE2920", VA = "0x186EE4120")]
	public static void MCOOEKPKDIP(Stream NEOJHOCIJKI, MHNGHFOJBBP CMMCIHFHBLL, NGOHLNDOJLJ HOIJLNKGLFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public enum PMOKIHGBLKM : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	WindowsDesktop,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	MobileIOS,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	MobileAndroid,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	OculusQuest,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	XboxOne,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Playstation4,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	Playstation5
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[AttributeUsage(AttributeTargets.Field)]
public class LOJIIEDMHCC : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x92DE00", Offset = "0x92C600", VA = "0x18092DE00")]
	public LOJIIEDMHCC()
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class RecRoomStudioChipMetadata : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct IndividualChipMetadata
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			[HideInInspector]
			[SerializeField]
			private SerializedGuid guid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			[SerializeField]
			public string ClassName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			[SerializeField]
			public string FriendlyName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			[SerializeField]
			public string Description;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			[SerializeField]
			public List<string> Filters;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			[SerializeField]
			public bool IsBetaChip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			[SerializeField]
			public bool IsHiddenInPalette;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			[SerializeField]
			public bool IsDevChip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			[SerializeField]
			public bool IsStudioChip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			[SerializeField]
			public bool IsTrollingRisk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			[SerializeField]
			public bool IsRoleAssignmentRisk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			[SerializeField]
			public List<PortDesc> InputPorts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			[SerializeField]
			public List<PortDesc> OutputPorts;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct PortDesc
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			[SerializeField]
			public string Name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			[SerializeField]
			public string Type;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		public List<IndividualChipMetadata> MetadataList;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9C90", Offset = "0x6EE8490", VA = "0x186EE9C90")]
		public RecRoomStudioChipMetadata()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public enum FFKAAAMLJCO
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Environment = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Decoration = 1,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Physical = 4
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public enum JPEDHLIDFFA
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Environment = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Decoration = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	Physical_Sticky = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Physical = 4
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class RecRoomObjectConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[LOJIIEDMHCC]
		[SerializeField]
		private bool isBuiltInObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[SerializeField]
		[Header("Basic Interactions")]
		private bool isFrozen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[SerializeField]
		[GDMGCFENDJO("isClimbable", false, "Is Grabbable can only be enabled if Is Climbable is not enabled")]
		private bool isGrabbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[SerializeField]
		[GDMGCFENDJO("isGrabbable", false, "Is Climbable can only be enabled if Is Grabbable is not enabled")]
		private bool isClimbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[SerializeField]
		private bool supportsWallRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[SerializeField]
		private bool supportsClambering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[SerializeField]
		[EENCOIALCEB("isBuiltInObject", false, false)]
		[Header("Physics")]
		private FFKAAAMLJCO physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[SerializeField]
		[EENCOIALCEB("isShapeContainer", true, false)]
		private JPEDHLIDFFA shapePhysicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[HideInInspector]
		[SerializeField]
		private bool isShapeContainer;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool IsBuiltInObject
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x8B1630", Offset = "0x8AFE30", VA = "0x1808B1630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8780", Offset = "0x6EE6F80", VA = "0x186EE8780")]
		public RecRoomObjectConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class JDKNGLCFPFA : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4440", Offset = "0x6EE2C40", VA = "0x186EE4440")]
	protected JDKNGLCFPFA(string OHNDBNDIBPN, bool INCMGOFNCLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[AttributeUsage(AttributeTargets.Field)]
public class EENCOIALCEB : JDKNGLCFPFA
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4270", Offset = "0x6EE2A70", VA = "0x186EE4270")]
	public EENCOIALCEB(string OHNDBNDIBPN, bool NGIPOINNIKM, bool INCMGOFNCLP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[AttributeUsage(AttributeTargets.Field)]
public class AOGHOAAELNP : JDKNGLCFPFA
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2550", Offset = "0x6EE0D50", VA = "0x186EE2550")]
	public AOGHOAAELNP(string OHNDBNDIBPN, int NGIPOINNIKM, bool INCMGOFNCLP = false)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class MaterialMapAsset : RecRoomStudioBuildAsset<MaterialMapAsset>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[SerializeField]
		private MaterialMap.MaterialEntry[] entries;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MaterialMap.MaterialEntry[] Entries
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x107FC60", Offset = "0x107E460", VA = "0x18107FC60")]
		public void CBOLGOHENHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6EE55A0", Offset = "0x6EE3DA0", VA = "0x186EE55A0")]
		public MaterialMapAsset()
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
