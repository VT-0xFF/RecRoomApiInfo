using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6C34E90", Offset = "0x6C34090", VA = "0x186C34E90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C0750", Offset = "0x8BF950", VA = "0x1808C0750")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8C0790", Offset = "0x8BF990", VA = "0x1808C0790")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AOIIHODOFLK : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1966710", Offset = "0x1965910", VA = "0x181966710")]
	public AOIIHODOFLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, EKCEOHHBDFD, PDKKEMCMCAA, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8944A0", Offset = "0x8936A0", VA = "0x1808944A0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x897BB0", Offset = "0x896DB0", VA = "0x180897BB0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash LAJLGEDGOJD);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xA0A330", Offset = "0xA09530", VA = "0x180A0A330")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[ReadOnlyField]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[SerializeField]
	[HideInInspector]
	[ReadOnlyField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C361A0", Offset = "0x6C353A0", VA = "0x186C361A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6C36160", Offset = "0x6C35360", VA = "0x186C36160")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6C361E0", Offset = "0x6C353E0", VA = "0x186C361E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6C36390", Offset = "0x6C35590", VA = "0x186C36390")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6C36300", Offset = "0x6C35500", VA = "0x186C36300")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA0F670", Offset = "0xA0E870", VA = "0x180A0F670")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xB6EBF0", Offset = "0xB6DDF0", VA = "0x180B6EBF0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C36120", Offset = "0x6C35320", VA = "0x186C36120")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C36270", Offset = "0x6C35470", VA = "0x186C36270")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6C35BC0", Offset = "0x6C34DC0", VA = "0x186C35BC0")]
	public void CopyBounds(SavedExtents KDHPJMADEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C36070", Offset = "0x6C35270", VA = "0x186C36070")]
	public void SetLocalSpaceBounds(Bounds PHNPLPPMOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xE4E8F0", Offset = "0xE4DAF0", VA = "0x180E4E8F0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6C36060", Offset = "0x6C35260", VA = "0x186C36060")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C35CB0", Offset = "0x6C34EB0", VA = "0x186C35CB0")]
	private void ILMIBBNEIOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6C35E60", Offset = "0x6C35060", VA = "0x186C35E60")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6C35580", Offset = "0x6C34780", VA = "0x186C35580")]
	public static void CalculateLocalBoundsFor(GameObject PLNJOBKLAEE, [Out] Bounds PHNPLPPMOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6C35BF0", Offset = "0x6C34DF0", VA = "0x186C35BF0")]
	private static void DACBIACCCCH(Bounds EGCFJOLCAMD, Color GPOLJDKBMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C36090", Offset = "0x6C35290", VA = "0x186C36090")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8941A0", Offset = "0x8933A0", VA = "0x1808941A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x897BE0", Offset = "0x896DE0", VA = "0x180897BE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x12A26A0", Offset = "0x12A18A0", VA = "0x1812A26A0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4CA7270", Offset = "0x4CA6470", VA = "0x184CA7270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "4")]
	public virtual void FHHHPAGMLJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[AOIIHODOFLK]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4CA6DC0", Offset = "0x4CA5FC0", VA = "0x184CA6DC0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4CA5500", Offset = "0x4CA4700", VA = "0x184CA5500", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4CA7170", Offset = "0x4CA6370", VA = "0x184CA7170")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class MLHIECLJABN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public MLHIECLJABN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x47BFBF0", Offset = "0x47BEDF0", VA = "0x1847BFBF0")]
		internal int CCCADNPGKIC(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[AOIIHODOFLK]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3AFEC60", Offset = "0x3AFDE60", VA = "0x183AFEC60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3AFECC0", Offset = "0x3AFDEC0", VA = "0x183AFECC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3AFEB40", Offset = "0x3AFDD40", VA = "0x183AFEB40", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey CPBLLDDDHEE]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3AFEC00", Offset = "0x3AFDE00", VA = "0x183AFEC00", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3AFE9F0", Offset = "0x3AFDBF0", VA = "0x183AFE9F0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3AFE690", Offset = "0x3AFD890", VA = "0x183AFE690", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3AFDA50", Offset = "0x3AFCC50", VA = "0x183AFDA50", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD8C0", Offset = "0x3AFCAC0", VA = "0x183AFD8C0", Slot = "14")]
	protected virtual string CDKIBLLCPKE(TKeyVal LKFNGPILILD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD950", Offset = "0x3AFCB50", VA = "0x183AFD950", Slot = "4")]
	public bool ContainsKey(TKey CPBLLDDDHEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3AFE870", Offset = "0x3AFDA70", VA = "0x183AFE870", Slot = "5")]
	public bool TryGetValue(TKey CPBLLDDDHEE, [Out] TVal JECHHBGMFLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD9B0", Offset = "0x3AFCBB0", VA = "0x183AFD9B0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD9B0", Offset = "0x3AFCBB0", VA = "0x183AFD9B0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3AFE8D0", Offset = "0x3AFDAD0", VA = "0x183AFE8D0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class SerializedReferenceKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeReference]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8941F0", Offset = "0x8933F0", VA = "0x1808941F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8944A0", Offset = "0x8936A0", VA = "0x1808944A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	protected SerializedReferenceKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class SerializedReferenceDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class SerializedReferenceKeyValuePair : SerializedReferenceKeyVal<TKey, TVal>
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3E91950", Offset = "0x3E90B50", VA = "0x183E91950")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[AOIIHODOFLK]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4CA8470", Offset = "0x4CA7670", VA = "0x184CA8470", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4CA7A20", Offset = "0x4CA6C20", VA = "0x184CA7A20", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4CA7170", Offset = "0x4CA6370", VA = "0x184CA7170")]
	protected SerializedReferenceDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class MJMPBAOAAGD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class CBEIJMJNOLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float PBOFNKMPNDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T GOGBANOMEKC;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public CBEIJMJNOLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class BJFCGKCPONI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public BJFCGKCPONI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x52DBA90", Offset = "0x52DAC90", VA = "0x1852DBA90")]
		internal bool PAGMOIBKFKM(CBEIJMJNOLE sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly float AIKCCDCFAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly float IMPIFHKFDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private List<CBEIJMJNOLE> PCCKDLLODKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private NMMLHOGNHKL<CBEIJMJNOLE> OKBIDENFJPG;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int LHKADFMOCGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x47AB210", Offset = "0x47AA410", VA = "0x1847AB210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x47AB4A0", Offset = "0x47AA6A0", VA = "0x1847AB4A0")]
	public MJMPBAOAAGD(float NLPFJINADME, float FJALDLDNFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x47AAE80", Offset = "0x47AA080", VA = "0x1847AAE80")]
	public bool JAJHMFCKBBL(float APFBMHLAJIF, T JECHHBGMFLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x47AA7A0", Offset = "0x47A99A0", VA = "0x1847AA7A0")]
	public IEnumerable<T> EPMEPJLPFEG(float APFBMHLAJIF, [Optional] float? DLDOIKHGMPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x47AA6F0", Offset = "0x47A98F0", VA = "0x1847AA6F0")]
	public void AODHOHPPLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x47AB2F0", Offset = "0x47AA4F0", VA = "0x1847AB2F0")]
	private void OBJEIJGNNCB(float APFBMHLAJIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class MPJJDNLHJEF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct GNOIGDOCJIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public T GOGBANOMEKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public float GOOCIEMHBOC;
	}

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static float ELDMDGDDHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private List<T> EJLDFFBNKAF;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const int KOCIEKIIBEF = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GNOIGDOCJIG[] IEIBCNCHGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int DEAOLFPGLNE;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float FBOEOHGLJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xC6E940", Offset = "0xC6DB40", VA = "0x180C6E940")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xC7EB90", Offset = "0xC7DD90", VA = "0x180C7EB90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x47CD140", Offset = "0x47CC340", VA = "0x1847CD140")]
	public MPJJDNLHJEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x47CD010", Offset = "0x47CC210", VA = "0x1847CD010")]
	public MPJJDNLHJEF(int JAICOMOJIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x47CC870", Offset = "0x47CBA70", VA = "0x1847CC870")]
	public void JIJNOIKPNBF(float APFBMHLAJIF, T JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x47CC020", Offset = "0x47CB220", VA = "0x1847CC020")]
	public void AODHOHPPLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x47CCAB0", Offset = "0x47CBCB0", VA = "0x1847CCAB0")]
	public bool ONHPJEJIOAL(float AMCBJCFOACD, float OAPFHJLNELE, [Out] T JECHHBGMFLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x47CC650", Offset = "0x47CB850", VA = "0x1847CC650")]
	public bool BHENHKJCEKL(float AMCBJCFOACD, float OAPFHJLNELE, [Out] T JECHHBGMFLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x47CC110", Offset = "0x47CB310", VA = "0x1847CC110")]
	public void BBNMMNNFEGH(float AMCBJCFOACD, float OAPFHJLNELE, List<T> GJBDDGHNJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x47CCA80", Offset = "0x47CBC80", VA = "0x1847CCA80")]
	private int LAFDANGFFEG(int JIICDPPBGFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x47CC820", Offset = "0x47CBA20", VA = "0x1847CC820")]
	private void FPKOHHHCKAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T DELJIKJBGFM();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T PHBLBFIGJJJ(T JECHHBGMFLN, float EBCBPNKDEPP);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T DNGGKHPOEDE(T ICLLFDEBJIO, T JPMAPOMKNPF);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T AEBGEKGHPNO(T ICLLFDEBJIO, T JPMAPOMKNPF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class AHJIGLJKJKM : MPJJDNLHJEF<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8A5A10", Offset = "0x8A4C10", VA = "0x1808A5A10", Slot = "4")]
	protected override Vector3 DELJIKJBGFM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6C31240", Offset = "0x6C30440", VA = "0x186C31240", Slot = "5")]
	protected override Vector3 PHBLBFIGJJJ(Vector3 JECHHBGMFLN, float EBCBPNKDEPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6C311F0", Offset = "0x6C303F0", VA = "0x186C311F0", Slot = "6")]
	protected override Vector3 DNGGKHPOEDE(Vector3 ICLLFDEBJIO, Vector3 JPMAPOMKNPF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6C31170", Offset = "0x6C30370", VA = "0x186C31170", Slot = "7")]
	protected override Vector3 AEBGEKGHPNO(Vector3 ICLLFDEBJIO, Vector3 JPMAPOMKNPF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6C31280", Offset = "0x6C30480", VA = "0x186C31280")]
	public AHJIGLJKJKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class IIBEBPFMHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2E55FA0", Offset = "0x2E551A0", VA = "0x182E55FA0")]
	public static OPFNFBLNGLF<T1, T2> LGJIMIKIEOH<T1, T2>(T1 JKGOLLOJKHF, T2 NFJHOLJEKKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2E56040", Offset = "0x2E55240", VA = "0x182E56040")]
	public static OMBALOOGCPP<T1, T2, T3> LGJIMIKIEOH<T1, T2, T3>(T1 JKGOLLOJKHF, T2 NFJHOLJEKKJ, T3 CBKILKKCLOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x47FFE50", Offset = "0x47FF050", VA = "0x1847FFE50")]
	internal static int GLKBLBKIHHC(int OOKBINGIJBK, int MLILKMNLKCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC400", Offset = "0x5FCB600", VA = "0x185FCC400")]
	internal static int GLKBLBKIHHC(int OOKBINGIJBK, int MLILKMNLKCF, int LNHDOKNPFGL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OPFNFBLNGLF<T1, T2> : IComparable<OPFNFBLNGLF<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T1 AIAOFPLDKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T2 ICAIMJFOADH;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x49BCE80", Offset = "0x49BC080", VA = "0x1849BCE80")]
	public OPFNFBLNGLF(T1 JKGOLLOJKHF, T2 NFJHOLJEKKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x49BB1B0", Offset = "0x49BA3B0", VA = "0x1849BB1B0", Slot = "4")]
	public int CompareTo(OPFNFBLNGLF<T1, T2> KDHPJMADEAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x49BBA50", Offset = "0x49BAC50", VA = "0x1849BBA50", Slot = "0")]
	public override bool Equals(object KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x49BC120", Offset = "0x49BB320", VA = "0x1849BC120", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x49BC830", Offset = "0x49BBA30", VA = "0x1849BC830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OMBALOOGCPP<T1, T2, T3> : IComparable<OMBALOOGCPP<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly T1 AIAOFPLDKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly T2 ICAIMJFOADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T3 PGGLGDAJOBH;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x497F0B0", Offset = "0x497E2B0", VA = "0x18497F0B0")]
	public OMBALOOGCPP(T1 JKGOLLOJKHF, T2 NFJHOLJEKKJ, T3 CBKILKKCLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x497E8A0", Offset = "0x497DAA0", VA = "0x18497E8A0", Slot = "4")]
	public int CompareTo(OMBALOOGCPP<T1, T2, T3> KDHPJMADEAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x497E9F0", Offset = "0x497DBF0", VA = "0x18497E9F0", Slot = "0")]
	public override bool Equals(object KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x497ECC0", Offset = "0x497DEC0", VA = "0x18497ECC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x497EF00", Offset = "0x497E100", VA = "0x18497EF00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T GOGBANOMEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2542970", Offset = "0x2541B70", VA = "0x182542970")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2542820", Offset = "0x2541A20", VA = "0x182542820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float CBPPJNNHLBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE00", Offset = "0xA1B000", VA = "0x180A1BE00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC780", Offset = "0x4EEB980", VA = "0x184EEC780")]
	public T DPKLPEDMNLC(float EBCBPNKDEPP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC8B0", Offset = "0x4EEBAB0", VA = "0x184EEC8B0")]
	public T HJAEDALPOKK(float EBCBPNKDEPP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T HGPAKAPPBKE(T ICLLFDEBJIO, T JPMAPOMKNPF, float EBCBPNKDEPP);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6C331E0", Offset = "0x6C323E0", VA = "0x186C331E0", Slot = "4")]
	protected override float HGPAKAPPBKE(float ICLLFDEBJIO, float JPMAPOMKNPF, float EBCBPNKDEPP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6C33220", Offset = "0x6C32420", VA = "0x186C33220")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1124780", Offset = "0x1123980", VA = "0x181124780", Slot = "4")]
	protected override Vector3 HGPAKAPPBKE(Vector3 ICLLFDEBJIO, Vector3 JPMAPOMKNPF, float EBCBPNKDEPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6C37160", Offset = "0x6C36360", VA = "0x186C37160")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6C31D30", Offset = "0x6C30F30", VA = "0x186C31D30", Slot = "4")]
	protected override Color HGPAKAPPBKE(Color ICLLFDEBJIO, Color JPMAPOMKNPF, float EBCBPNKDEPP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6C31DF0", Offset = "0x6C30FF0", VA = "0x186C31DF0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MMHEEHOCMJJ : LOJGGECOGMA<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6C33DD0", Offset = "0x6C32FD0", VA = "0x186C33DD0")]
	public MMHEEHOCMJJ(int LCNCMFGPICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6C33D60", Offset = "0x6C32F60", VA = "0x186C33D60", Slot = "6")]
	protected override uint DOJCDPGCGLG(uint LAJLGEDGOJD, string JECHHBGMFLN)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LNGCDJBOIHE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly IDisposable FAKOKDPOOAM;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public LNGCDJBOIHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct GAPCJJIHIGD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> EJANKKIDKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int BDEOLLKOGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int BCIHPEPHMHN;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3F58AA0", Offset = "0x3F57CA0", VA = "0x183F58AA0")]
	private GAPCJJIHIGD(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> ODOEOAICKLN, int IINKPPBOOHC, int APBAMLHINFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3F589A0", Offset = "0x3F57BA0", VA = "0x183F589A0")]
	public static GAPCJJIHIGD<T> MIFIOLMMIDE()
	{
		return default(GAPCJJIHIGD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3F56CA0", Offset = "0x3F55EA0", VA = "0x183F56CA0")]
	public (int, int, Task<T>) GJNCDCNKJMD(int NKKKMBMGHIH, [Optional] CancellationToken DDNLBFLLCLM, double NPIKCMPEMNK = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3F58410", Offset = "0x3F57610", VA = "0x183F58410")]
	public void HHGBFDDKFCB(int NKKKMBMGHIH, int APBAMLHINFA, [In] T KHPJAGHLNBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class BHGGCJCPFOO
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6C313F0", Offset = "0x6C305F0", VA = "0x186C313F0")]
	public static GAPCJJIHIGD<EPFCCNCFAEJ> MIFIOLMMIDE()
	{
		return default(GAPCJJIHIGD<EPFCCNCFAEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6C31370", Offset = "0x6C30570", VA = "0x186C31370")]
	public static void HHGBFDDKFCB([In] this GAPCJJIHIGD<EPFCCNCFAEJ> AEFKHDNCNFD, int NKKKMBMGHIH, int APBAMLHINFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class EPNOFOKAAJB<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<TKey, TVal> ABENCEPFIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TVal, TKey> AIMJCINLDLH;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int HDFADKJDLLO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x383DF00", Offset = "0x383D100", VA = "0x18383DF00", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool CFPKGOMMBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public ICollection<TKey> LOCGEIOJDJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3AFA6E0", Offset = "0x3AF98E0", VA = "0x183AFA6E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public ICollection<TVal> CHNBFAGHCBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3AFA730", Offset = "0x3AF9930", VA = "0x183AFA730", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TVal MEOINHFNJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3AFA620", Offset = "0x3AF9820", VA = "0x183AFA620", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3AFA7C0", Offset = "0x3AF99C0", VA = "0x183AFA7C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public TKey MEOINHFNJFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3AFA2E0", Offset = "0x3AF94E0", VA = "0x183AFA2E0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3AF9980", Offset = "0x3AF8B80", VA = "0x183AF9980", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3AFA450", Offset = "0x3AF9650", VA = "0x183AFA450", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3AF9850", Offset = "0x3AF8A50", VA = "0x183AF9850", Slot = "9")]
	public void Add(TKey CPBLLDDDHEE, TVal JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3AF98A0", Offset = "0x3AF8AA0", VA = "0x183AF98A0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LFDONPLGGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3AF9A20", Offset = "0x3AF8C20", VA = "0x183AF9A20", Slot = "8")]
	public bool ContainsKey(TKey CPBLLDDDHEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3AF9AB0", Offset = "0x3AF8CB0", VA = "0x183AF9AB0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> LFDONPLGGIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3AFA380", Offset = "0x3AF9580", VA = "0x183AFA380", Slot = "10")]
	public bool Remove(TKey CPBLLDDDHEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3AFA340", Offset = "0x3AF9540", VA = "0x183AFA340", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> LFDONPLGGIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3AFA4A0", Offset = "0x3AF96A0", VA = "0x183AFA4A0", Slot = "11")]
	public bool TryGetValue(TKey CPBLLDDDHEE, [Out] TVal JECHHBGMFLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3AF9E60", Offset = "0x3AF9060", VA = "0x183AF9E60", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3AF9AF0", Offset = "0x3AF8CF0", VA = "0x183AF9AF0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] IEIBCNCHGJN, int AEOBJDNFNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3AF9E00", Offset = "0x3AF9000", VA = "0x183AF9E00")]
	public bool GOLMABOLCED(TVal CPBLLDDDHEE, [Out] TKey JECHHBGMFLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3AF9FD0", Offset = "0x3AF91D0", VA = "0x183AF9FD0")]
	private void HCBDLJFBLOE(TKey CPBLLDDDHEE, TVal MIOIFIAKEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3AFA0C0", Offset = "0x3AF92C0", VA = "0x183AFA0C0")]
	private void JOLAEMEBPJB(TKey CPBLLDDDHEE, TVal MIOIFIAKEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3AF9C80", Offset = "0x3AF8E80", VA = "0x183AF9C80")]
	private bool DCNBJDEHCAL(TKey CPBLLDDDHEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3AFA500", Offset = "0x3AF9700", VA = "0x183AFA500")]
	public EPNOFOKAAJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class PNFMNNPAENJ<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private PNFMNNPAENJ<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x3B491B0", Offset = "0x3B483B0", VA = "0x183B491B0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x3B4EBD0", Offset = "0x3B4DDD0", VA = "0x183B4EBD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3B4F690", Offset = "0x3B4E890", VA = "0x183B4F690")]
		public Enumerator(PNFMNNPAENJ<T> GJBDDGHNJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3B4C760", Offset = "0x3B4B960", VA = "0x183B4C760", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3B4D770", Offset = "0x3B4C970", VA = "0x183B4D770", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3B4B3D0", Offset = "0x3B4A5D0", VA = "0x183B4B3D0")]
		private void AOECAEDIICI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T[] EEGPNJAIAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int GFHPFKLIAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private int IADHLICNKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private int AIIGKGFGNPA;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int HDFADKJDLLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4AB9360", Offset = "0x4AB8560", VA = "0x184AB9360")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public T MEOINHFNJFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4AB9490", Offset = "0x4AB8690", VA = "0x184AB9490")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4AB9900", Offset = "0x4AB8B00", VA = "0x184AB9900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4AB9DE0", Offset = "0x4AB8FE0", VA = "0x184AB9DE0")]
	public PNFMNNPAENJ(int LCNCMFGPICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4AB9060", Offset = "0x4AB8260", VA = "0x184AB9060")]
	public void JIJNOIKPNBF(T EBCBPNKDEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4AB7D60", Offset = "0x4AB6F60", VA = "0x184AB7D60")]
	public void AODHOHPPLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4AB9A30", Offset = "0x4AB8C30", VA = "0x184AB9A30")]
	public void NHIOCMPPKDC(int NDEFEFEFLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4AB8060", Offset = "0x4AB7260", VA = "0x184AB8060")]
	public void CADOELBOBIE(T[] IEIBCNCHGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4AB7C50", Offset = "0x4AB6E50", VA = "0x184AB7C50")]
	public Enumerator AKJNNDDNIOE()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4AB9C80", Offset = "0x4AB8E80", VA = "0x184AB9C80", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4AB9C80", Offset = "0x4AB8E80", VA = "0x184AB9C80", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4AB8C40", Offset = "0x4AB7E40", VA = "0x184AB8C40")]
	private int IAANCJBJCDG(int KINMHNEMPOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4AB8620", Offset = "0x4AB7820", VA = "0x184AB8620")]
	private int FANHABBMONF(int KINMHNEMPOD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class EOINJFJBFND<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate Task<TResult> NBJIOELEEHA(TRequest LGIKLBJKNEM, CancellationToken DDNLBFLLCLM);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public enum HCJLGBHOGNC
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class FCOCNPEOPIM
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private const float OCKGMCLCGAK = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TimeSpan CGJEMEJHLAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int BJPAMIGDPOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public HCJLGBHOGNC EIGBCFOAKMC;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public static readonly FCOCNPEOPIM OFNBBIHJLBF;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float PFIIDIKHLDG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x3E778D0", Offset = "0x3E76AD0", VA = "0x183E778D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan OJLANAKFLID
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3E779B0", Offset = "0x3E76BB0", VA = "0x183E779B0")]
		public FCOCNPEOPIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private readonly struct JGCPJECHDNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly TRequest LGIKLBJKNEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly CancellationToken DDNLBFLLCLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly TaskCompletionSource<TResult> AMHGEHKPELL;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x435AE00", Offset = "0x435A000", VA = "0x18435AE00")]
		public JGCPJECHDNO(TRequest LGIKLBJKNEM, TaskCompletionSource<TResult> AMHGEHKPELL, CancellationToken DDNLBFLLCLM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct HDADAJGOMLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public EOINJFJBFND<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4016E50", Offset = "0x4016050", VA = "0x184016E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4017250", Offset = "0x4016450", VA = "0x184017250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct ENIFLCOGHDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public EOINJFJBFND<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private JGCPJECHDNO <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3AF29E0", Offset = "0x3AF1BE0", VA = "0x183AF29E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3AF3020", Offset = "0x3AF2220", VA = "0x183AF3020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly CancellationTokenSource DNIMHELDIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<JGCPJECHDNO> GODJJDODOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly FCOCNPEOPIM LNCOFHFDLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly NBJIOELEEHA LDDJEKOFOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Task BDNDKAIIOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int FHGHMPMEJPE;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5E60", Offset = "0x3AF5060", VA = "0x183AF5E60")]
	public EOINJFJBFND(NBJIOELEEHA LDDJEKOFOFB, [Optional] FCOCNPEOPIM LNCOFHFDLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5AB0", Offset = "0x3AF4CB0", VA = "0x183AF5AB0")]
	public Task<TResult> OEJMLHILOAF(TRequest LGIKLBJKNEM, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3AF4C10", Offset = "0x3AF3E10", VA = "0x183AF4C10")]
	private void ECNJILJAMCJ(JGCPJECHDNO NCIKBGLLMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3AF4DB0", Offset = "0x3AF3FB0", VA = "0x183AF4DB0")]
	[AsyncStateMachine(typeof(EOINJFJBFND<, >.HDADAJGOMLI))]
	private Task FEJBKDDELIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3AF4520", Offset = "0x3AF3720", VA = "0x183AF4520")]
	private JGCPJECHDNO AGOBBACBHAM()
	{
		return default(JGCPJECHDNO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5020", Offset = "0x3AF4220", VA = "0x183AF5020")]
	[AsyncStateMachine(typeof(EOINJFJBFND<, >.ENIFLCOGHDN))]
	private Task FLHFKMHIOJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5500", Offset = "0x3AF4700", VA = "0x183AF5500")]
	private void KANAKLCNHHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3AF4AF0", Offset = "0x3AF3CF0", VA = "0x183AF4AF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class CMKPHBGGHBP<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly List<T> NAGHBLHDGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private HashSet<T> NONGBJEAJBO;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int HDFADKJDLLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x383DF00", Offset = "0x383D100", VA = "0x18383DF00", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool CFPKGOMMBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T MEOINHFNJFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2CA79E0", Offset = "0x2CA6BE0", VA = "0x182CA79E0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x57CA850", Offset = "0x57C9A50", VA = "0x1857CA850", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3ECF890", Offset = "0x3ECEA90", VA = "0x183ECF890", Slot = "11")]
	public void Add(T LFDONPLGGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x57C9E80", Offset = "0x57C9080", VA = "0x1857C9E80")]
	public bool HBJMKOIICBA(T LFDONPLGGIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x57CA670", Offset = "0x57C9870", VA = "0x1857CA670", Slot = "15")]
	public bool Remove(T LFDONPLGGIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3AC9EF0", Offset = "0x3AC90F0", VA = "0x183AC9EF0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3E63800", Offset = "0x3E62A00", VA = "0x183E63800", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x57C9D30", Offset = "0x57C8F30", VA = "0x1857C9D30", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x57C9DD0", Offset = "0x57C8FD0", VA = "0x1857C9DD0", Slot = "13")]
	public bool Contains(T LFDONPLGGIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x57C9E20", Offset = "0x57C9020", VA = "0x1857C9E20", Slot = "14")]
	public void CopyTo(T[] IEIBCNCHGJN, int AEOBJDNFNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4507E80", Offset = "0x4507080", VA = "0x184507E80", Slot = "6")]
	public int IndexOf(T LFDONPLGGIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x57CA1D0", Offset = "0x57C93D0", VA = "0x1857CA1D0", Slot = "7")]
	public void Insert(int KINMHNEMPOD, T LFDONPLGGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x57CA460", Offset = "0x57C9660", VA = "0x1857CA460", Slot = "8")]
	public void RemoveAt(int KINMHNEMPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x57CA730", Offset = "0x57C9930", VA = "0x1857CA730")]
	public CMKPHBGGHBP()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x23F7B60", Offset = "0x23F6D60", VA = "0x1823F7B60")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6C36730", Offset = "0x6C35930", VA = "0x186C36730")]
		public SerializedGuid([In] Guid KGBBBBHDKAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6C36600", Offset = "0x6C35800", VA = "0x186C36600")]
		public static SerializedGuid IEPOMPIJIGB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6C36420", Offset = "0x6C35620", VA = "0x186C36420")]
		public static SerializedGuid BAHGCGAOGNJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6C365A0", Offset = "0x6C357A0", VA = "0x186C365A0")]
		public bool IDJFCBEKMDN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6C36700", Offset = "0x6C35900", VA = "0x186C36700", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6C36680", Offset = "0x6C35880", VA = "0x186C36680", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6C364C0", Offset = "0x6C356C0", VA = "0x186C364C0", Slot = "7")]
		public bool Equals(SerializedGuid KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6C36500", Offset = "0x6C35700", VA = "0x186C36500", Slot = "0")]
		public override bool Equals(object JMJAOKJJFGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6C36590", Offset = "0x6C35790", VA = "0x186C36590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6C36490", Offset = "0x6C35690", VA = "0x186C36490", Slot = "6")]
		public int CompareTo(SerializedGuid KDHPJMADEAD)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class JLOCOKPBPAH : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly Type JBKDCHPANEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly string FPBAEOLJHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool KHONGCKIONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly bool IFFEMCAHLFJ;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6C33670", Offset = "0x6C32870", VA = "0x186C33670")]
	public JLOCOKPBPAH(Type BFPPKNNLFOC, string GIMPBAFDHFN, bool JKFDKBNBDCO = false, bool AGHHDALGLNF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class EMBFDJMFMNN<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public readonly struct DBDDJAHCLMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly long NMHJOPCBDMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly long BBLAPDHJBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly int KMCEDLAEJMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly int EBKAGMOCNGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly bool OIMLJADDEGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly string MJCMIAEKGAK;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5B22EF0", Offset = "0x5B220F0", VA = "0x185B22EF0")]
		public DBDDJAHCLMA(long NMHJOPCBDMG, int KMCEDLAEJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5B22F60", Offset = "0x5B22160", VA = "0x185B22F60")]
		public DBDDJAHCLMA(long NMHJOPCBDMG, long BBLAPDHJBDM, int KMCEDLAEJMI, int EBKAGMOCNGI, bool OIMLJADDEGP, string MJCMIAEKGAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5B22D80", Offset = "0x5B21F80", VA = "0x185B22D80")]
		public int ACKDBCMBEIC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5B22DD0", Offset = "0x5B21FD0", VA = "0x185B22DD0")]
		public int AOFPODACBFD(int KAGIHDHNCJP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5B22E90", Offset = "0x5B22090", VA = "0x185B22E90")]
		public double LOICDIHIDBI()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5B22DF0", Offset = "0x5B21FF0", VA = "0x185B22DF0")]
		public DBDDJAHCLMA IPPGEJHCOJH(long BBLAPDHJBDM, int EBKAGMOCNGI)
		{
			return default(DBDDJAHCLMA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class MHBPMONHJAC : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private struct KANBJODOJIJ<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public MHBPMONHJAC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public Func<MHBPMONHJAC, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private MHBPMONHJAC <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x4469EC0", Offset = "0x44690C0", VA = "0x184469EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x3ACF5E0", Offset = "0x3ACE7E0", VA = "0x183ACF5E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public readonly TKey KEBPHANPJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly EMBFDJMFMNN<TKey> MOKDAJBBPHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public readonly GAFGFHIJEHD ACKGBNDHEHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private List<MHBPMONHJAC> CCCOIEADCED;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string EAAKNDFIEOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x4786A00", Offset = "0x4785C00", VA = "0x184786A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<MHBPMONHJAC> JCEJBAIOFOM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x4786CD0", Offset = "0x4785ED0", VA = "0x184786CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public DBDDJAHCLMA AGDFGLACBFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x4786EC0", Offset = "0x47860C0", VA = "0x184786EC0")]
			[CompilerGenerated]
			get
			{
				return default(DBDDJAHCLMA);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x4786CA0", Offset = "0x4785EA0", VA = "0x184786CA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4786EE0", Offset = "0x47860E0", VA = "0x184786EE0")]
		internal MHBPMONHJAC(EMBFDJMFMNN<TKey> MOKDAJBBPHK, TKey CPBLLDDDHEE, GAFGFHIJEHD ACKGBNDHEHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4786D10", Offset = "0x4785F10", VA = "0x184786D10")]
		public MHBPMONHJAC LLMEKIABHHK(TKey CPBLLDDDHEE, [Optional] GAFGFHIJEHD? PFFJPECKGMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3192DE0", Offset = "0x3191FE0", VA = "0x183192DE0")]
		[AsyncStateMachine(typeof(KANBJODOJIJ<>))]
		public Task<T> JKPDIEIKKBH<T>(TKey CPBLLDDDHEE, Func<MHBPMONHJAC, Task<T>> OMCFGJPALAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4786A50", Offset = "0x4785C50", VA = "0x184786A50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class OICMCBFOKAI : IEnumerable<(TKey, List<TKey>, DBDDJAHCLMA)>, IEnumerable, IEnumerator<(TKey, List<TKey>, DBDDJAHCLMA)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private (TKey key, List<TKey> path, DBDDJAHCLMA timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public EMBFDJMFMNN<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private IEnumerator<(TKey key, List<TKey> path, DBDDJAHCLMA timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, DBDDJAHCLMA) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x23E8DB0", Offset = "0x23E7FB0", VA = "0x1823E8DB0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, DBDDJAHCLMA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x496ECA0", Offset = "0x496DEA0", VA = "0x18496ECA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x23E8EA0", Offset = "0x23E80A0", VA = "0x1823E8EA0")]
		[DebuggerHidden]
		public OICMCBFOKAI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F140", Offset = "0x3D1E340", VA = "0x183D1F140", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x496E740", Offset = "0x496D940", VA = "0x18496E740", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x496EB30", Offset = "0x496DD30", VA = "0x18496EB30")]
		private void ODPIAJHKBMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x496EC50", Offset = "0x496DE50", VA = "0x18496EC50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x496EB80", Offset = "0x496DD80", VA = "0x18496EB80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, DBDDJAHCLMA)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5120", Offset = "0x3AD4320", VA = "0x183AD5120", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class LBPGPDPKPOL : IEnumerable<(TKey, List<TKey>, DBDDJAHCLMA)>, IEnumerable, IEnumerator<(TKey, List<TKey>, DBDDJAHCLMA)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private (TKey key, List<TKey> path, DBDDJAHCLMA timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private MHBPMONHJAC timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public MHBPMONHJAC <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public EMBFDJMFMNN<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<MHBPMONHJAC> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private IEnumerator<(TKey key, List<TKey> path, DBDDJAHCLMA timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, DBDDJAHCLMA) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x23E8DB0", Offset = "0x23E7FB0", VA = "0x1823E8DB0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, DBDDJAHCLMA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x4533660", Offset = "0x4532860", VA = "0x184533660", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x23E8EA0", Offset = "0x23E80A0", VA = "0x1823E8EA0")]
		[DebuggerHidden]
		public LBPGPDPKPOL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x45336C0", Offset = "0x45328C0", VA = "0x1845336C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4532CA0", Offset = "0x4531EA0", VA = "0x184532CA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4533470", Offset = "0x4532670", VA = "0x184533470")]
		private void ODPIAJHKBMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4532C40", Offset = "0x4531E40", VA = "0x184532C40")]
		private void FNDCHHHCBCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4533610", Offset = "0x4532810", VA = "0x184533610", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x45334D0", Offset = "0x45326D0", VA = "0x1845334D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, DBDDJAHCLMA)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x45335D0", Offset = "0x45327D0", VA = "0x1845335D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly Action<TKey, DBDDJAHCLMA, GAFGFHIJEHD> IKIDIANKAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Action<TKey, DBDDJAHCLMA, GAFGFHIJEHD> LMDGPPPDEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Action<EMBFDJMFMNN<TKey>, GAFGFHIJEHD> CEJLKCECBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly GAFGFHIJEHD ACKGBNDHEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly MHBPMONHJAC KOIELOMCNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool JBMLAGGIALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int JDILFLBPMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Stopwatch COOAFOCOAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int OFINJJOEBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private string DMKHDNKIAJE;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public MHBPMONHJAC POOKAGKMKIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8944C0", Offset = "0x8936C0", VA = "0x1808944C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string EAAKNDFIEOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x894480", Offset = "0x893680", VA = "0x180894480")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6670", Offset = "0x3AE5870", VA = "0x183AE6670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3AE69A0", Offset = "0x3AE5BA0", VA = "0x183AE69A0")]
	public EMBFDJMFMNN(TKey BHLANCFHOFG, GAFGFHIJEHD ACKGBNDHEHM, [Optional] int? KMCEDLAEJMI, [Optional][CanBeNull] Stopwatch COOAFOCOAMC, [Optional] Action<TKey, DBDDJAHCLMA, GAFGFHIJEHD> IKIDIANKAJP, [Optional] Action<TKey, DBDDJAHCLMA, GAFGFHIJEHD> LMDGPPPDEBJ, [Optional] Action<EMBFDJMFMNN<TKey>, GAFGFHIJEHD> CEJLKCECBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3AE66D0", Offset = "0x3AE58D0", VA = "0x183AE66D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6820", Offset = "0x3AE5A20", VA = "0x183AE6820")]
	[IteratorStateMachine(typeof(EMBFDJMFMNN<>.OICMCBFOKAI))]
	public IEnumerable<(TKey, List<TKey>, DBDDJAHCLMA)> OOFNPMPFHJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3AE68C0", Offset = "0x3AE5AC0", VA = "0x183AE68C0")]
	[IteratorStateMachine(typeof(EMBFDJMFMNN<>.LBPGPDPKPOL))]
	private IEnumerable<(TKey, List<TKey>, DBDDJAHCLMA)> OOFNPMPFHJB(List<TKey> PBNPILECCPK, MHBPMONHJAC HILGLALCONB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3AE67A0", Offset = "0x3AE59A0", VA = "0x183AE67A0")]
	private (long, int) LPIGFJPEPDM()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class HCICCECMHND<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut CKIEFODJDLM(EMBFDJMFMNN<TKey> MOKDAJBBPHK);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	protected HCICCECMHND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class EPBCCIJPKCP<TKey> : HCICCECMHND<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate string BFMEGLPJHEC(TKey CPBLLDDDHEE);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6180", Offset = "0x3AF5380", VA = "0x183AF6180")]
	private static string AANBODEGDOK(TKey CPBLLDDDHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3AF61C0", Offset = "0x3AF53C0", VA = "0x183AF61C0", Slot = "4")]
	public override string CKIEFODJDLM(EMBFDJMFMNN<TKey> MOKDAJBBPHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3AF62A0", Offset = "0x3AF54A0", VA = "0x183AF62A0")]
	public string CKIEFODJDLM(EMBFDJMFMNN<TKey> MOKDAJBBPHK, [NotNull] BFMEGLPJHEC HMJIABMOPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string EEAKAECGANK(EMBFDJMFMNN<TKey> MOKDAJBBPHK, [NotNull] BFMEGLPJHEC HMJIABMOPBA);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3AF63F0", Offset = "0x3AF55F0", VA = "0x183AF63F0")]
	protected EPBCCIJPKCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class DHLAHJDLPDO<TKey> : HCICCECMHND<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate string BNEDMPEPOLH(TKey CPBLLDDDHEE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string JLFMOLNIAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly double LMCPIOPLNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly bool NKNHFFLBLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly int BPILMHMJJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ISet<string> PONNDENPJEC;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5B2CDF0", Offset = "0x5B2BFF0", VA = "0x185B2CDF0")]
	private static string AANBODEGDOK(TKey CPBLLDDDHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5B2DA50", Offset = "0x5B2CC50", VA = "0x185B2DA50")]
	public DHLAHJDLPDO(string JLFMOLNIAED = "F2", double LMCPIOPLNPM = double.MaxValue, bool NKNHFFLBLEJ = false, int BPILMHMJJAL = int.MaxValue, [Optional] ISet<string> PONNDENPJEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5B2D4D0", Offset = "0x5B2C6D0", VA = "0x185B2D4D0", Slot = "4")]
	public override Dictionary<string, string> CKIEFODJDLM(EMBFDJMFMNN<TKey> MOKDAJBBPHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5B2D820", Offset = "0x5B2CA20", VA = "0x185B2D820")]
	private bool PNGPOFBCFLF(string HHKGKEJPBMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5B2CE30", Offset = "0x5B2C030", VA = "0x185B2CE30")]
	public Dictionary<string, string> CKIEFODJDLM(EMBFDJMFMNN<TKey> MOKDAJBBPHK, BNEDMPEPOLH HMJIABMOPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5B2D5B0", Offset = "0x5B2C7B0", VA = "0x185B2D5B0")]
	private string EKDOJGPGKKA(StringBuilder GEOHGBIIFLP, List<TKey> KKKLODNNOFL, BNEDMPEPOLH HMJIABMOPBA, bool LEMANCBLNKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5B2D8F0", Offset = "0x5B2CAF0", VA = "0x185B2D8F0")]
	private static void PPAGHCBEGGD(StringBuilder DEPEBNKCIMJ, string CPECELLEPHG, bool KBEDKAMBHBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class BCJFGPGGLPP<TKey> : EPBCCIJPKCP<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct ONAKGJEALPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public BFMEGLPJHEC keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static BCJFGPGGLPP<TKey> FAKOKDPOOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly string[] KMNDOMNJHHD;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x51C84A0", Offset = "0x51C76A0", VA = "0x1851C84A0")]
	private BCJFGPGGLPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x51C7450", Offset = "0x51C6650", VA = "0x1851C7450", Slot = "5")]
	protected override string EEAKAECGANK(EMBFDJMFMNN<TKey> MOKDAJBBPHK, BFMEGLPJHEC HMJIABMOPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x51C8260", Offset = "0x51C7460", VA = "0x1851C8260")]
	[CompilerGenerated]
	internal static string EKBJMFBONCC(string GMJPPCMFEFL, TKey CPBLLDDDHEE, ONAKGJEALPG P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class DBFICMCKOLK : EMBFDJMFMNN<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class BELFEBHJGJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Action<DBFICMCKOLK, GAFGFHIJEHD> callback;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public BELFEBHJGJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6C312E0", Offset = "0x6C304E0", VA = "0x186C312E0")]
		internal void PJFPADMECHJ(EMBFDJMFMNN<string> timer, GAFGFHIJEHD log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6C31EF0", Offset = "0x6C310F0", VA = "0x186C31EF0")]
	public DBFICMCKOLK(GAFGFHIJEHD ACKGBNDHEHM, [Optional] string GFPGIODBFNP, [Optional] int? KMCEDLAEJMI, [Optional] Stopwatch COOAFOCOAMC, [Optional] Action<string, DBDDJAHCLMA, GAFGFHIJEHD> IKIDIANKAJP, [Optional] Action<string, DBDDJAHCLMA, GAFGFHIJEHD> LMDGPPPDEBJ, [Optional] Action<DBFICMCKOLK, GAFGFHIJEHD> CEJLKCECBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6C31E30", Offset = "0x6C31030", VA = "0x186C31E30")]
	private static Action<EMBFDJMFMNN<string>, GAFGFHIJEHD> OGFBCGOOCHP(Action<DBFICMCKOLK, GAFGFHIJEHD> FKNFKAHALGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class LKPHLIEPCJA
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class OLAPFDDDIGN : LKPHLIEPCJA
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static LKPHLIEPCJA FAKOKDPOOAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x6C34F10", Offset = "0x6C34110", VA = "0x186C34F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float DLAJGJMLIOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xC59F50", Offset = "0xC59150", VA = "0x180C59F50", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6C35000", Offset = "0x6C34200", VA = "0x186C35000")]
		public OLAPFDDDIGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static LKPHLIEPCJA LNNIALJFJNG;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static LKPHLIEPCJA OFNBBIHJLBF
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6C336E0", Offset = "0x6C328E0", VA = "0x186C336E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float DLAJGJMLIOK
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	protected LKPHLIEPCJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface JHFIGENECJN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool NBBOOJLBJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface NMANDIAIDGE<T> : JHFIGENECJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	[NotNull]
	Task<T> NCKOPAEIIKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	[NotNull]
	PIHPPMDHIHB<T> JLCNKMOLJBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class JHFMONDAINC
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2E77C70", Offset = "0x2E76E70", VA = "0x182E77C70")]
	public static NMANDIAIDGE<TResource> ALAGKMKGGPJ<TResource, TId>(this AEEPOAHLHPA<TId, TResource> MNONINFHDLB, TId MHMAFIBKDFF, [Optional] Func<TId, CancellationToken, Task<TResource>>? OJIFBEBFEMF) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class CNIBCHCGBPO
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class KHIFGCDJCFE<T> : PHGFAFOKJOP<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T?> NCKOPAEIIKI
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override PIHPPMDHIHB<T?> JLCNKMOLJBM
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x44A44A0", Offset = "0x44A36A0", VA = "0x1844A44A0")]
		public KHIFGCDJCFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "10")]
		protected override void JNNBJPBADHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class DOBFLLPACMA<T> : PHGFAFOKJOP<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly T IKCLJHBDFFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Action<T>? CEBKNKBEKNI;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> NCKOPAEIIKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8942D0", Offset = "0x8934D0", VA = "0x1808942D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override PIHPPMDHIHB<T> JLCNKMOLJBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8942E0", Offset = "0x8934E0", VA = "0x1808942E0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5B45990", Offset = "0x5B44B90", VA = "0x185B45990")]
		public DOBFLLPACMA(T DKECFALHIPG, Action<T>? NBNNJMECLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5B45750", Offset = "0x5B44950", VA = "0x185B45750", Slot = "10")]
		protected override void JNNBJPBADHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class DLHDEIFIJBF<T> : PHGFAFOKJOP<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T> NCKOPAEIIKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override PIHPPMDHIHB<T> JLCNKMOLJBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5B36BE0", Offset = "0x5B35DE0", VA = "0x185B36BE0")]
		public DLHDEIFIJBF(Exception DJGHECPCKKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "10")]
		protected override void JNNBJPBADHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class EHOCGNPPGHF<T> : PHGFAFOKJOP<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct KFPHJNHJKKB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public Task<NMANDIAIDGE<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<NMANDIAIDGE<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x4495E40", Offset = "0x4495040", VA = "0x184495E40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x4496820", Offset = "0x4495A20", VA = "0x184496820", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct INMMEJMGAAK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public Task<NMANDIAIDGE<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<NMANDIAIDGE<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x41849C0", Offset = "0x4183BC0", VA = "0x1841849C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x4184C50", Offset = "0x4183E50", VA = "0x184184C50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly Task<NMANDIAIDGE<T>> NHPNMCEPBBJ;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override Task<T> NCKOPAEIIKI
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override PIHPPMDHIHB<T> JLCNKMOLJBM
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x894500", Offset = "0x893700", VA = "0x180894500", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3AD3070", Offset = "0x3AD2270", VA = "0x183AD3070")]
		public EHOCGNPPGHF(Task<NMANDIAIDGE<T>> HMHJFGCCEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3AD2B40", Offset = "0x3AD1D40", VA = "0x183AD2B40", Slot = "10")]
		protected override void JNNBJPBADHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3AD2D40", Offset = "0x3AD1F40", VA = "0x183AD2D40")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(EHOCGNPPGHF<>.KFPHJNHJKKB))]
		internal static Task<T> LLNNENNEKAC(Task<NMANDIAIDGE<T>> HMHJFGCCEGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3AD2EB0", Offset = "0x3AD20B0", VA = "0x183AD2EB0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(EHOCGNPPGHF<>.INMMEJMGAAK))]
		internal static Task MGNAANCDJLL(Task<NMANDIAIDGE<T>> HMHJFGCCEGP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class PEINBMNOKEN<TIn, TOut> : PHGFAFOKJOP<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct AKEIGGJNNCM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x3F9EBC0", Offset = "0x3F9DDC0", VA = "0x183F9EBC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x3AD6390", Offset = "0x3AD5590", VA = "0x183AD6390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly NMANDIAIDGE<TIn> EFCEKIMFFFG;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<TOut> NCKOPAEIIKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override PIHPPMDHIHB<TOut> JLCNKMOLJBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x894500", Offset = "0x893700", VA = "0x180894500", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x4A87630", Offset = "0x4A86830", VA = "0x184A87630")]
		public PEINBMNOKEN(NMANDIAIDGE<TIn> HMPCABCOIHG, Func<TIn, TOut> KJOOGGEICNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x4A875E0", Offset = "0x4A867E0", VA = "0x184A875E0", Slot = "10")]
		protected override void JNNBJPBADHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x4A87410", Offset = "0x4A86610", VA = "0x184A87410")]
		[AsyncStateMachine(typeof(PEINBMNOKEN<, >.AKEIGGJNNCM))]
		[CompilerGenerated]
		internal static Task<TOut> JLANFPFCFBN(Task<TIn> KAAKGBLIFMO, Func<TIn, TOut> KJOOGGEICNG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2C25CB0", Offset = "0x2C24EB0", VA = "0x182C25CB0")]
	public static NMANDIAIDGE<T> NPJAAMJGCPB<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2C25B60", Offset = "0x2C24D60", VA = "0x182C25B60")]
	public static NMANDIAIDGE<T> FJMOGKOJMMC<T>(T KHPJAGHLNBM, [Optional] Action<T>? NBNNJMECLBA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2C25AD0", Offset = "0x2C24CD0", VA = "0x182C25AD0")]
	public static NMANDIAIDGE<T> AJDDACGJDBP<T>(Exception DJGHECPCKKM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2C25AD0", Offset = "0x2C24CD0", VA = "0x182C25AD0")]
	public static NMANDIAIDGE<T> OECPOHMEEFH<T>(Task<NMANDIAIDGE<T>> HMHJFGCCEGP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2C25C10", Offset = "0x2C24E10", VA = "0x182C25C10")]
	public static NMANDIAIDGE<TOut> HFFBGEFJFMD<TOut, TIn>(NMANDIAIDGE<TIn> OLMIMHPMKPE, Func<TIn, TOut> KJOOGGEICNG) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class PHGFAFOKJOP<T> : NMANDIAIDGE<T>, JHFIGENECJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly string JHBKADJPECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly HMNHFOHBAHD FPCKNHDGBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool JBMLAGGIALE;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool NBBOOJLBJGO
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xE2E4F0", Offset = "0xE2D6F0", VA = "0x180E2E4F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public abstract Task<T> NCKOPAEIIKI
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public abstract PIHPPMDHIHB<T> JLCNKMOLJBM
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x4AA8240", Offset = "0x4AA7440", VA = "0x184AA8240")]
	public PHGFAFOKJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4AA7DC0", Offset = "0x4AA6FC0", VA = "0x184AA7DC0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void JNNBJPBADHC();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class HDNLHEFEKAA<TTask, T> : PHGFAFOKJOP<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class EOCIDIKGFBK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public EOCIDIKGFBK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x382BC40", Offset = "0x382AE40", VA = "0x18382BC40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x382C190", Offset = "0x382B390", VA = "0x18382C190", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public HDNLHEFEKAA<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public EOCIDIKGFBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3AF3E10", Offset = "0x3AF3010", VA = "0x183AF3E10")]
		[AsyncStateMachine(typeof(HDNLHEFEKAA<, >.EOCIDIKGFBK.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> DDIGLKLMHDB(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Task<T> HMHJFGCCEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	protected readonly CancellationTokenSource MOPJKINAACG;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override Task<T> NCKOPAEIIKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override PIHPPMDHIHB<T> JLCNKMOLJBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x4018F00", Offset = "0x4018100", VA = "0x184018F00")]
	protected HDNLHEFEKAA(TTask HMHJFGCCEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x4018EB0", Offset = "0x40180B0", VA = "0x184018EB0", Slot = "10")]
	protected override void JNNBJPBADHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T BPBAHHLOKJA(TTask GIGCOPIBLKF);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void BKBGOKOLGFD();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class LKCNPJADAGJ<T> : PHGFAFOKJOP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly GENINCKMOLO<Task<T>> NEOGKMCJKEM;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public override Task<T> NCKOPAEIIKI
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3FC5E20", Offset = "0x3FC5020", VA = "0x183FC5E20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public override PIHPPMDHIHB<T> JLCNKMOLJBM
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x4558D40", Offset = "0x4557F40", VA = "0x184558D40")]
	public LKCNPJADAGJ(GENINCKMOLO<Task<T>> FCPNBAGGMBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4558D20", Offset = "0x4557F20", VA = "0x184558D20", Slot = "10")]
	protected override void JNNBJPBADHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class BJOPIAAGNDL
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static readonly HashAlgorithmName ACPHPCFDIHN;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly ThreadLocal<IncrementalHash> GNJHGNIDMAG;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6C31B70", Offset = "0x6C30D70", VA = "0x186C31B70")]
	public static int OCBMAALDCPB(this EKCEOHHBDFD IHHJMNKFADD, IncrementalHash LAJLGEDGOJD, byte[] OACPEIOPEOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6C31440", Offset = "0x6C30640", VA = "0x186C31440")]
	public static bool CFNNNLCJIKF([CanBeNull] this EKCEOHHBDFD IHHJMNKFADD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6C317D0", Offset = "0x6C309D0", VA = "0x186C317D0")]
	public static bool CFNNNLCJIKF([CanBeNull] this EKCEOHHBDFD IHHJMNKFADD, [Out] string BAHJDCJDFHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6C314A0", Offset = "0x6C306A0", VA = "0x186C314A0")]
	public static bool CFNNNLCJIKF([CanBeNull] this EKCEOHHBDFD IHHJMNKFADD, IncrementalHash LAJLGEDGOJD, byte[] OACPEIOPEOC, [Out] string BAHJDCJDFHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6C31AE0", Offset = "0x6C30CE0", VA = "0x186C31AE0")]
	private static bool GEAJKPGNNKJ(byte[] NFDAMHHKMAP, Span<byte> OAOLAHNHDLO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class JDPFOHLHLOL
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6C33260", Offset = "0x6C32460", VA = "0x186C33260")]
	public static int EJEHKCLDPOA(HashAlgorithmName HJOEMDPBJPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6C333B0", Offset = "0x6C325B0", VA = "0x186C333B0")]
	public static int OCBMAALDCPB(this PDKKEMCMCAA HOJEEFJJIKE, byte[] MAFFKPNOGJL, IncrementalHash LAJLGEDGOJD, byte[] BGGCDOIBJLI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface PDKKEMCMCAA
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash LAJLGEDGOJD);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface EKCEOHHBDFD : PDKKEMCMCAA
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	[CanBeNull]
	byte[] MPKLFKPHJOH
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	[CanBeNull]
	byte[] AAKIIGBJEMP
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class DDPCKIAKNFE
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static bool IFPGBGPOOPP;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ArrayPool<byte> BMAKDIBJAEJ;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly ArrayPool<char> KJMKIAKGFNK;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly Encoding EJMADFJGOMN;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly ThreadLocal<Encoder> CBFOFILHOMF;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2C639E0", Offset = "0x2C62BE0", VA = "0x182C639E0")]
	public static void ODMFOFLFAEH<T>(this IncrementalHash IHFIMCILKMA, [CanBeNull] T OPAHHNBNPOH) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2C63950", Offset = "0x2C62B50", VA = "0x182C63950")]
	public static void NDKEFNHPPMM<T>(this IncrementalHash IHFIMCILKMA, [CanBeNull] T HOJEEFJJIKE) where T : PDKKEMCMCAA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x2C63430", Offset = "0x2C62630", VA = "0x182C63430")]
	public static void KHECGMAOMFJ<T>(this IncrementalHash IHFIMCILKMA, [CanBeNull] IList<T> BHNACKDKLDM) where T : PDKKEMCMCAA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6C32630", Offset = "0x6C31830", VA = "0x186C32630")]
	private static bool FEDKOONNMCK([CanBeNull] PDKKEMCMCAA HOJEEFJJIKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6C320A0", Offset = "0x6C312A0", VA = "0x186C320A0")]
	public static void DEPNPGBFJDD(this IncrementalHash LAJLGEDGOJD, string? OJIAAJCCCDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6C326C0", Offset = "0x6C318C0", VA = "0x186C326C0")]
	public static void GNDNJPNBPBJ(this IncrementalHash LAJLGEDGOJD, long DAHNJJDCCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6C32A60", Offset = "0x6C31C60", VA = "0x186C32A60")]
	public static void KGGEABOFPBO(this IncrementalHash LAJLGEDGOJD, int JDKJKMGJLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6C32C90", Offset = "0x6C31E90", VA = "0x186C32C90")]
	public static void LMHKBFKICNA(this IncrementalHash LAJLGEDGOJD, short DDIMHNDAMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6C32E60", Offset = "0x6C32060", VA = "0x186C32E60")]
	public static void NLDPPBGILEK(this IncrementalHash LAJLGEDGOJD, byte MEEMBKDFAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6C32890", Offset = "0x6C31A90", VA = "0x186C32890")]
	public static void JFNMHCKKBNJ(this IncrementalHash LAJLGEDGOJD, bool NIEBFDJOBDA, bool HDDDEPDMCCG = false, bool OEIBDIIJNGM = false, bool KAGGIDGGJGE = false, bool JOIEDJOEGGO = false, bool FDMECPNOPEH = false, bool CPAEMHMGOBB = false, bool GMIPNJPHNOM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2C62E00", Offset = "0x2C62000", VA = "0x182C62E00")]
	public static void AFOKCBKPOMA<T>(this IncrementalHash LAJLGEDGOJD, T ODDCGAGBKJJ) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6C325D0", Offset = "0x6C317D0", VA = "0x186C325D0")]
	public static void EKOLBEKFFCG(this IncrementalHash LAJLGEDGOJD, float DGDMGBGDPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6C32040", Offset = "0x6C31240", VA = "0x186C32040")]
	public static void AKPFICNNFOP(this IncrementalHash LAJLGEDGOJD, ulong OHCNMPIKHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6C32C30", Offset = "0x6C31E30", VA = "0x186C32C30")]
	public static void LDNPPABIDKD(this IncrementalHash LAJLGEDGOJD, uint DMDNFCGBLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6C32A00", Offset = "0x6C31C00", VA = "0x186C32A00")]
	public static void JHPAENDDIEI(this IncrementalHash LAJLGEDGOJD, ushort LKBLCMNNKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6C324A0", Offset = "0x6C316A0", VA = "0x186C324A0")]
	public static void DMNGPDEAKAN(this IncrementalHash LAJLGEDGOJD, Vector3 DCMNFPIJDPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class JJEFBBDPOME : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6C33610", Offset = "0x6C32810", VA = "0x186C33610")]
	public JJEFBBDPOME(string ADNFLGLLNKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class FPLEFALCIJH<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal class NMEHACMNGLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public TNode AEFKHDNCNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public TNode MBOJNCFILKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public MLOCDFLOFBB LCANHDHOBOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public List<MLOCDFLOFBB> KDJGIMFGOEF;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public NMEHACMNGLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal struct MLOCDFLOFBB : IComparable<MLOCDFLOFBB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int PFDDBFPHACL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public TClaimant PIFALFLJOJK;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x1070F90", Offset = "0x1070190", VA = "0x181070F90")]
		public MLOCDFLOFBB(int PFDDBFPHACL, TClaimant PIFALFLJOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x47C1600", Offset = "0x47C0800", VA = "0x1847C1600")]
		public bool DLPOOLJJGLD([In] MLOCDFLOFBB KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x47C1660", Offset = "0x47C0860", VA = "0x1847C1660")]
		public bool EEFJAANOBEL([In] MLOCDFLOFBB KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x47C15F0", Offset = "0x47C07F0", VA = "0x1847C15F0", Slot = "4")]
		public int CompareTo(MLOCDFLOFBB KDHPJMADEAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x47C1670", Offset = "0x47C0870", VA = "0x1847C1670", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum COEONAMJPPO
	{
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class ENGBIJPDDHL : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public FPLEFALCIJH<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x9D6DA0", Offset = "0x9D5FA0", VA = "0x1809D6DA0")]
		[DebuggerHidden]
		public ENGBIJPDDHL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1B20", Offset = "0x3AF0D20", VA = "0x183AF1B20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1D40", Offset = "0x3AF0F40", VA = "0x183AF1D40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1C00", Offset = "0x3AF0E00", VA = "0x183AF1C00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1D00", Offset = "0x3AF0F00", VA = "0x183AF1D00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly NMMLHOGNHKL<NMEHACMNGLF> LHBAJGIAKJI;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly NMMLHOGNHKL<List<MLOCDFLOFBB>> DHGJOOBGOHD;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static int FCPKBCELAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal readonly Dictionary<TClaimant, TNode> KAOEKPPHOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	internal readonly Dictionary<TNode, NMEHACMNGLF> KNAMLOLBEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private COEONAMJPPO MEOGGEENDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool HLBKMNGGNJD;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode GIBOCKIFPIG(TNode MOPDELCEJCO);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void GGHAPCJKFHF(TNode MOPDELCEJCO, TClaimant KLPMHFHICNK, TClaimant LFGNJHFLIIK);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3EB8E00", Offset = "0x3EB8000", VA = "0x183EB8E00")]
	public FPLEFALCIJH(COEONAMJPPO MEOGGEENDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3EB8A80", Offset = "0x3EB7C80", VA = "0x183EB8A80")]
	public void MJDHNALJCOC(TNode MOPDELCEJCO, TNode PNMFMJOGIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3EB7320", Offset = "0x3EB6520", VA = "0x183EB7320")]
	public void CMOJHOBGCKH(TClaimant PIFALFLJOJK, TNode LCHMPLHOBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3EB7600", Offset = "0x3EB6800", VA = "0x183EB7600", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3EB8080", Offset = "0x3EB7280", VA = "0x183EB8080")]
	private void FJBMGELEFEE(TClaimant PIFALFLJOJK, TNode KGBCDANFPDC, TNode LCHMPLHOBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3EB8280", Offset = "0x3EB7480", VA = "0x183EB8280")]
	private int KAFCHBLAAAK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3EB7800", Offset = "0x3EB6A00", VA = "0x183EB7800")]
	private void EEOGBJPOALH(TClaimant PIFALFLJOJK, TNode NDILKMOOFFC, TNode BIIGGECJCHI, int LFMFFLDKGMD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x3EB7E30", Offset = "0x3EB7030", VA = "0x183EB7E30")]
	private void ELFKFIBHAPA(MLOCDFLOFBB KCFJLNEGHGH, NMEHACMNGLF EFECIMDANAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x3EB7B50", Offset = "0x3EB6D50", VA = "0x183EB7B50")]
	private void EGGLLHFBALF(TClaimant PIFALFLJOJK, TNode NDILKMOOFFC, TNode BIIGGECJCHI, int LFMFFLDKGMD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x3EB8150", Offset = "0x3EB7350", VA = "0x183EB8150")]
	private void JKLHINODDJG(MLOCDFLOFBB KCFJLNEGHGH, TNode MOPDELCEJCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x3EB74A0", Offset = "0x3EB66A0", VA = "0x183EB74A0")]
	private void CPEHHEPJOOF(MLOCDFLOFBB KCFJLNEGHGH, NMEHACMNGLF EFECIMDANAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x3EB8400", Offset = "0x3EB7600", VA = "0x183EB8400")]
	private void KLJHBILALGF(NMEHACMNGLF EFECIMDANAO, bool EEEJDKGMIGK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3EB8710", Offset = "0x3EB7910", VA = "0x183EB8710")]
	private void LOLKABLFGNF(NMEHACMNGLF EFECIMDANAO, TNode PNMFMJOGIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3EB8B40", Offset = "0x3EB7D40", VA = "0x183EB8B40")]
	[IteratorStateMachine(typeof(FPLEFALCIJH<, >.ENGBIJPDDHL))]
	private IEnumerable<TNode> OHAALJOCMDP(TNode NDILKMOOFFC, TNode BIIGGECJCHI, bool FAGMOGHOGBO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3EB82F0", Offset = "0x3EB74F0", VA = "0x183EB82F0")]
	private NMEHACMNGLF KLIMDNNGOCN(TNode MOPDELCEJCO, TNode MBOJNCFILKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3EB7F00", Offset = "0x3EB7100", VA = "0x183EB7F00")]
	private NMEHACMNGLF FAHACIIOLOA(TNode MOPDELCEJCO, TNode MBOJNCFILKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3EB8550", Offset = "0x3EB7750", VA = "0x183EB8550")]
	private void LENGDCPKBOA(NMEHACMNGLF EFECIMDANAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class LOJGGECOGMA<T> : IEnumerable<LOJGGECOGMA<T>.NMLDIPLPCHE>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct NMLDIPLPCHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public T JECHHBGMFLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int KINMHNEMPOD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class MPGNIPLGJLL : IEnumerator<NMLDIPLPCHE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private LOJGGECOGMA<T> PBMGPHBCJCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int KINMHNEMPOD;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3AFF810", Offset = "0x3AFEA10", VA = "0x183AFF810", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public NMLDIPLPCHE HLBNAJGJPKH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x47CB2D0", Offset = "0x47CA4D0", VA = "0x1847CB2D0", Slot = "4")]
			get
			{
				return default(NMLDIPLPCHE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x47CB290", Offset = "0x47CA490", VA = "0x1847CB290")]
		public MPGNIPLGJLL(LOJGGECOGMA<T> PBMGPHBCJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x47CB190", Offset = "0x47CA390", VA = "0x1847CB190", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3B54DB0", Offset = "0x3B53FB0", VA = "0x183B54DB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xBD3130", Offset = "0xBD2330", VA = "0x180BD3130", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct DCHNJHFAIEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public bool LECPNONGHAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public T JECHHBGMFLN;
	}

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private const int NGBAJOOFABJ = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Dictionary<T, int> HJHIIEEIOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private DCHNJHFAIEE[] IOOPGFBIJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private int KOEMLLJLCOE;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public int HGGKEOHPDOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A10", Offset = "0x8D4C10", VA = "0x1808D5A10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8D5600", Offset = "0x8D4800", VA = "0x1808D5600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int HDFADKJDLLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x383DF00", Offset = "0x383D100", VA = "0x18383DF00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x456F410", Offset = "0x456E610", VA = "0x18456F410")]
	public LOJGGECOGMA(int LCNCMFGPICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x456F500", Offset = "0x456E700", VA = "0x18456F500")]
	public LOJGGECOGMA(NMLDIPLPCHE[] JLBDLKHOHCP, bool JDOKJDJFOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x456EDE0", Offset = "0x456DFE0", VA = "0x18456EDE0")]
	public int NFDLEJKKBDO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x456E340", Offset = "0x456D540", VA = "0x18456E340")]
	private int AOEEEOBDDEA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x456E590", Offset = "0x456D790", VA = "0x18456E590", Slot = "6")]
	protected virtual uint DOJCDPGCGLG(uint LAJLGEDGOJD, T JECHHBGMFLN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x456ECC0", Offset = "0x456DEC0", VA = "0x18456ECC0")]
	public bool HLPONNDHDEI(T JECHHBGMFLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x456EBE0", Offset = "0x456DDE0", VA = "0x18456EBE0")]
	public int HDBLKHLAGPP(T JECHHBGMFLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x456ED20", Offset = "0x456DF20", VA = "0x18456ED20")]
	public T IKLGAEEKKLK(int KINMHNEMPOD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x456E5B0", Offset = "0x456D7B0", VA = "0x18456E5B0")]
	public bool HBJMKOIICBA(T JECHHBGMFLN, bool FKHPIOBGNJB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x456E900", Offset = "0x456DB00", VA = "0x18456E900")]
	public bool HBJMKOIICBA(T JECHHBGMFLN, int KINMHNEMPOD, bool FKHPIOBGNJB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x456EEF0", Offset = "0x456E0F0", VA = "0x18456EEF0")]
	private int PDIFJGIJDBK(int GFHPFKLIAOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x456EF40", Offset = "0x456E140", VA = "0x18456EF40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x456EF40", Offset = "0x456E140", VA = "0x18456EF40", Slot = "4")]
	private IEnumerator<NMLDIPLPCHE> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class NMMLHOGNHKL<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly Stack<T> GBANJLPKCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly List<T> ELMDBHIKNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly int HNGKCOEFCON;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4864560", Offset = "0x4863760", VA = "0x184864560")]
	public static NMMLHOGNHKL<T> PFLBJDOHJND(int LCNCMFGPICH = 0, int HNGKCOEFCON = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4863D00", Offset = "0x4862F00", VA = "0x184863D00")]
	public static NMMLHOGNHKL<T> DAFNAICMAIN(int LCNCMFGPICH = 0, int HNGKCOEFCON = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x4864860", Offset = "0x4863A60", VA = "0x184864860")]
	public NMMLHOGNHKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x4864650", Offset = "0x4863850", VA = "0x184864650")]
	public NMMLHOGNHKL(int LCNCMFGPICH, int HNGKCOEFCON = int.MaxValue, bool EKKIJEMLMDO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4864390", Offset = "0x4863590", VA = "0x184864390")]
	public T MIINEHAMMLL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x4864080", Offset = "0x4863280", VA = "0x184864080")]
	public void IMHGPOENCOG(T JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4863F80", Offset = "0x4863180", VA = "0x184863F80")]
	private void GPHGEGMJHJE(T JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x4864350", Offset = "0x4863550", VA = "0x184864350")]
	private void KBLDMIAJDJI(T JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4863DF0", Offset = "0x4862FF0", VA = "0x184863DF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4864160", Offset = "0x4863360", VA = "0x184864160")]
	private void JMGFGJIAKKD(IEnumerable<T> JFBMKPGOEFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class BDPLFGPBDBC<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Dictionary<int, T> HEPGHFONHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private T DPNOFLLBKEJ;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public virtual T DLDHFAIGLCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8944A0", Offset = "0x8936A0", VA = "0x1808944A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x51C92C0", Offset = "0x51C84C0", VA = "0x1851C92C0")]
	public bool MNIPKGIAFIL(T JECHHBGMFLN, int PFDDBFPHACL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x456B5E0", Offset = "0x456A7E0", VA = "0x18456B5E0")]
	public bool PCHNNANGKFF(int PFDDBFPHACL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x51C8B90", Offset = "0x51C7D90", VA = "0x1851C8B90")]
	public T FANPLIGEAGE(int BIGHJPCEPBA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x51C9080", Offset = "0x51C8280", VA = "0x1851C9080")]
	private bool FLJNIKOOPIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x51C91C0", Offset = "0x51C83C0", VA = "0x1851C91C0")]
	public bool GOLMABOLCED(int PFDDBFPHACL, [Out] T JECHHBGMFLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x456B680", Offset = "0x456A880", VA = "0x18456B680")]
	public BDPLFGPBDBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class OCOOKCLLINB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	protected struct HBECOJICOFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public T GOGBANOMEKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int OJIBFOCIOPJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	protected readonly List<HBECOJICOFG> EEGPNJAIAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private T FFEOKKFHHCI;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int HDFADKJDLLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x383DF00", Offset = "0x383D100", VA = "0x18383DF00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4956450", Offset = "0x4955650", VA = "0x184956450")]
	public bool IMBCHPJELFP(T JECHHBGMFLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4956B40", Offset = "0x4955D40", VA = "0x184956B40")]
	public void JIJNOIKPNBF(T JECHHBGMFLN, int PFDDBFPHACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4956CD0", Offset = "0x4955ED0", VA = "0x184956CD0")]
	public bool LOGGCHCCBFB(T JECHHBGMFLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4956280", Offset = "0x4955480", VA = "0x184956280")]
	public void AODHOHPPLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4956320", Offset = "0x4955520", VA = "0x184956320")]
	public T DLLJDAEHCEM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4956840", Offset = "0x4955A40", VA = "0x184956840")]
	protected void JHDHFEAJJLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4957040", Offset = "0x4956240", VA = "0x184957040")]
	public OCOOKCLLINB()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[SerializeField]
		[FICFPGOHBIA(IKBOIBNEMID.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x6C35180", Offset = "0x6C34380", VA = "0x186C35180")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x6C35450", Offset = "0x6C34650", VA = "0x186C35450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x6C35360", Offset = "0x6C34560", VA = "0x186C35360")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x6C350D0", Offset = "0x6C342D0", VA = "0x186C350D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x6C353A0", Offset = "0x6C345A0", VA = "0x186C353A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x6C352B0", Offset = "0x6C344B0", VA = "0x186C352B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6C35050", Offset = "0x6C34250", VA = "0x186C35050")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4C6C890", Offset = "0x4C6BA90", VA = "0x184C6C890", Slot = "4")]
		public virtual T FLOGLMGGCJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class NDDDONDIBKC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Dictionary<byte, LOHPIIOKNID> AGCPKLHMDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly NMMLHOGNHKL<LOHPIIOKNID> EOENDIPMCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly bool HLMLGKDBGAD;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public LOHPIIOKNID CCBLEPPHEDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8941F0", Offset = "0x8933F0", VA = "0x1808941F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector2 CBDGDIHAEJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xFDE440", Offset = "0xFDD640", VA = "0x180FDE440")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1313520", Offset = "0x1312720", VA = "0x181313520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private Vector2 NECHLCKHHBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x99CD10", Offset = "0x99BF10", VA = "0x18099CD10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Vector2 DKCBBPEGLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6C34CE0", Offset = "0x6C33EE0", VA = "0x186C34CE0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x894490", Offset = "0x893690", VA = "0x180894490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int FCAMJKIKMMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x89FAD0", Offset = "0x89ECD0", VA = "0x18089FAD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x89FAC0", Offset = "0x89ECC0", VA = "0x18089FAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6C34DD0", Offset = "0x6C33FD0", VA = "0x186C34DD0")]
	public NDDDONDIBKC(Bounds MKIALJFPHFG, Vector2[] MLLJGDPECLC, int ODOFJPJHEOP, byte GFHPFKLIAOK, float HOMDDJGDEOA = 0f, [Optional] NMMLHOGNHKL<LOHPIIOKNID> EOENDIPMCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6C34710", Offset = "0x6C33910", VA = "0x186C34710")]
	public void HMJAKOECNFA(Bounds MKIALJFPHFG, Vector2[] MLLJGDPECLC, int ODOFJPJHEOP, byte GFHPFKLIAOK, float HOMDDJGDEOA = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6C34C80", Offset = "0x6C33E80", VA = "0x186C34C80")]
	public LOHPIIOKNID LIMLNONMBEA(byte KINMHNEMPOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6C34D00", Offset = "0x6C33F00", VA = "0x186C34D00")]
	public void OOBHBGEDKBA(Vector3 FJFKFIAGEPM, float OAFBJDOBHPJ, float MOFFEOPLOBJ, List<byte> HANGOKEFNJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6C33E20", Offset = "0x6C33020", VA = "0x186C33E20")]
	public void AANHEDKCKNG(LOHPIIOKNID.OMFBCIFDOMJ JOPLFBNILKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6C34BA0", Offset = "0x6C33DA0", VA = "0x186C34BA0")]
	public static int KCCGIFHOMHC(Vector2[] MLLJGDPECLC, int ODOFJPJHEOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6C33E40", Offset = "0x6C33040", VA = "0x186C33E40")]
	private LOHPIIOKNID CBEAHKHCAHJ(byte KINMHNEMPOD, LOHPIIOKNID.KGDGLFHNDKG JGHFJPECFKO, LOHPIIOKNID MBOJNCFILKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6C34350", Offset = "0x6C33550", VA = "0x186C34350")]
	private void HIBMFGILIII(LOHPIIOKNID MBOJNCFILKL, Vector2[] MLLJGDPECLC, int HOKGLOICNPJ, int CBHPHNJBFBF, int JHHCABDMDFJ, int IJBGNMHDDIB, float HOMDDJGDEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6C340D0", Offset = "0x6C332D0", VA = "0x186C340D0")]
	private void EGPCAPHLOJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6C34070", Offset = "0x6C33270", VA = "0x186C34070", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6C342F0", Offset = "0x6C334F0", VA = "0x186C342F0", Slot = "1")]
	~NDDDONDIBKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class LOHPIIOKNID
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum KGDGLFHNDKG
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public enum OMFBCIFDOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public byte CCBOBDNNGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Vector3 LJLJADGJPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public Vector3 NCANLJNAAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public Vector3 ELAFDGEPGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public Vector3 INPLDDJNLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public KGDGLFHNDKG KBHBGBHKFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public LOHPIIOKNID DHGIKLOJLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public List<LOHPIIOKNID> PCJPPDFKDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public bool CCFGMPLKPPC;

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6C33D40", Offset = "0x6C32F40", VA = "0x186C33D40")]
	public LOHPIIOKNID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6C33970", Offset = "0x6C32B70", VA = "0x186C33970")]
	public void HBLNCAGJJIE(LOHPIIOKNID EGONKIMCNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
	public void AANHEDKCKNG(int JLHPNCNHLOA, OMFBCIFDOMJ JOPLFBNILKL, int PFEKJKNNANJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6C33AE0", Offset = "0x6C32CE0", VA = "0x186C33AE0")]
	public void OOBHBGEDKBA(List<byte> HANGOKEFNJK, Vector3 FJFKFIAGEPM, float OAFBJDOBHPJ, float MOFFEOPLOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6C33AB0", Offset = "0x6C32CB0", VA = "0x186C33AB0")]
	public bool ONEOBPFDMPF(Vector3 IBDHOCLCOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6C33940", Offset = "0x6C32B40", VA = "0x186C33940")]
	public bool GJHMIAGGIFC(Vector3 IBDHOCLCOJC, float MIABEDEELHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6C338B0", Offset = "0x6C32AB0", VA = "0x186C338B0")]
	public void DDNLIMMJHCH()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public struct LOFOCOHCBMK<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private readonly List<Component> NAGHBLHDGIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private readonly bool OIONLBDKFFL;

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x4526CD0", Offset = "0x4525ED0", VA = "0x184526CD0")]
			public LOFOCOHCBMK(List<Component> NAGHBLHDGIK, bool OIONLBDKFFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x4568F00", Offset = "0x4568100", VA = "0x184568F00")]
			public MMCFALDKPGC<T> AKJNNDDNIOE()
			{
				return default(MMCFALDKPGC<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x4568F60", Offset = "0x4568160", VA = "0x184568F60", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x4568F60", Offset = "0x4568160", VA = "0x184568F60", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		public struct MMCFALDKPGC<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private readonly List<Component> NAGHBLHDGIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private readonly bool OIONLBDKFFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private int KINMHNEMPOD;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public T HLBNAJGJPKH
			{
				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x47C1810", Offset = "0x47C0A10", VA = "0x1847C1810", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x47C17A0", Offset = "0x47C09A0", VA = "0x1847C17A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x47C17E0", Offset = "0x47C09E0", VA = "0x1847C17E0")]
			public MMCFALDKPGC(List<Component> NAGHBLHDGIK, bool OIONLBDKFFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x47C16E0", Offset = "0x47C08E0", VA = "0x1847C16E0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x47C16F0", Offset = "0x47C08F0", VA = "0x1847C16F0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x3B46490", Offset = "0x3B45690", VA = "0x183B46490", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x6C36E40", Offset = "0x6C36040", VA = "0x186C36E40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6C36760", Offset = "0x6C35960", VA = "0x186C36760")]
		private void DDNLIMMJHCH(GameObject JPBDJFGELBF, bool PLHFEDHICDP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6C368D0", Offset = "0x6C35AD0", VA = "0x186C368D0")]
		public static void DDNLIMMJHCH(GameObject JPBDJFGELBF, ToolHierarchyCache MNONINFHDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6C36DA0", Offset = "0x6C35FA0", VA = "0x186C36DA0")]
		public void LGALDLIHMIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x313F1A0", Offset = "0x313E3A0", VA = "0x18313F1A0")]
		public void AJIFCCHILKE<T>(Action<T> ECFGAICLGCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x313F3E0", Offset = "0x313E5E0", VA = "0x18313F3E0")]
		public T AKPGHIFBPIM<T>(bool OIONLBDKFFL = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x313F480", Offset = "0x313E680", VA = "0x18313F480")]
		public LOFOCOHCBMK<T> LKAEHELKLMH<T>(bool OIONLBDKFFL = false) where T : class
		{
			return default(LOFOCOHCBMK<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6C36A50", Offset = "0x6C35C50", VA = "0x186C36A50")]
		public List<Component> JMLFGDJLNEN(Type EIHDAHDDDEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6C36960", Offset = "0x6C35B60", VA = "0x186C36960", Slot = "4")]
		public bool Equals(ToolHierarchyCache AKHPALIKFFK, ToolHierarchyCache PGLPHKNNCEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6C369E0", Offset = "0x6C35BE0", VA = "0x186C369E0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache JMJAOKJJFGJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class GLHDAMBIBAH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int LCNCMFGPICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int NIJGCJFIGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private List<T> MOJPKHAFJOM;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int HDFADKJDLLO
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3FC5E20", Offset = "0x3FC5020", VA = "0x183FC5E20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public T KDADLGIOJFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3FC5F30", Offset = "0x3FC5130", VA = "0x183FC5F30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public T GNNKGMDBBDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3FC5990", Offset = "0x3FC4B90", VA = "0x183FC5990")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public T GEGEAOFDKEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3FC6090", Offset = "0x3FC5290", VA = "0x183FC6090")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x3FC6180", Offset = "0x3FC5380", VA = "0x183FC6180")]
	public GLHDAMBIBAH(int LCNCMFGPICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x3FC5C60", Offset = "0x3FC4E60", VA = "0x183FC5C60")]
	public void JIJNOIKPNBF(T GILLMABLIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x3FC58C0", Offset = "0x3FC4AC0", VA = "0x183FC58C0")]
	public void AODHOHPPLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x3FC5A10", Offset = "0x3FC4C10", VA = "0x183FC5A10")]
	public void BDGPIPKPGBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x3FC5DC0", Offset = "0x3FC4FC0", VA = "0x183FC5DC0")]
	public void KOPGHMKHDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x3FC5B00", Offset = "0x3FC4D00", VA = "0x183FC5B00")]
	public void IJKMAGIJNCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x3FC6000", Offset = "0x3FC5200", VA = "0x183FC6000")]
	public List<T> OILCILODCHK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class NGDAPHIFHJJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private struct HIGCLMPDPIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public int OJIBFOCIOPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public T GOGBANOMEKC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly Dictionary<object, HIGCLMPDPIJ> HEPGHFONHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly EqualityComparer<T> OIHGPDIIJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private T DPNOFLLBKEJ;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public virtual T DLDHFAIGLCM
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x94BB50", Offset = "0x94AD50", VA = "0x18094BB50", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x482A2B0", Offset = "0x48294B0", VA = "0x18482A2B0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool DHCODKJBKDM
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x482A230", Offset = "0x4829430", VA = "0x18482A230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public object IKAPFABJIEN
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8944C0", Offset = "0x8936C0", VA = "0x1808944C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x89AD00", Offset = "0x899F00", VA = "0x18089AD00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x482DD70", Offset = "0x482CF70", VA = "0x18482DD70")]
	public bool MNIPKGIAFIL(T JECHHBGMFLN, object NIOIDOPDJKO, int PFDDBFPHACL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x482E6D0", Offset = "0x482D8D0", VA = "0x18482E6D0")]
	public bool PCHNNANGKFF(object NIOIDOPDJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x482D070", Offset = "0x482C270", VA = "0x18482D070")]
	public bool GOLMABOLCED(object NIOIDOPDJKO, [Out] T JECHHBGMFLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3AFA730", Offset = "0x3AF9930", VA = "0x183AFA730")]
	public void AODHOHPPLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x482C400", Offset = "0x482B600", VA = "0x18482C400")]
	private bool FLJNIKOOPIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x482E790", Offset = "0x482D990", VA = "0x18482E790")]
	public NGDAPHIFHJJ()
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
