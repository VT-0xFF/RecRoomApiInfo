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
using RecRoom.Core.DataStructures;
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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x82C2EB0", Offset = "0x82C18B0", VA = "0x1882C2EB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CAMOMJNCMBN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x234AA50", Offset = "0x2349450", VA = "0x18234AA50")]
	public CAMOMJNCMBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, HEDJGJLFGNJ, PDLFJFGONLE, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDE25D0", Offset = "0xDE0FD0", VA = "0x180DE25D0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash KEGBPMLIINA);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xD12090", Offset = "0xD10A90", VA = "0x180D12090")]
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
	[SerializeField]
	[ReadOnlyField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[SerializeField]
	[ReadOnlyField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x82C54B0", Offset = "0x82C3EB0", VA = "0x1882C54B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x82C5470", Offset = "0x82C3E70", VA = "0x1882C5470")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x82C54F0", Offset = "0x82C3EF0", VA = "0x1882C54F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x82C56A0", Offset = "0x82C40A0", VA = "0x1882C56A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x82C5610", Offset = "0x82C4010", VA = "0x1882C5610")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xADE030", Offset = "0xADCA30", VA = "0x180ADE030")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xADE3F0", Offset = "0xADCDF0", VA = "0x180ADE3F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x82C5430", Offset = "0x82C3E30", VA = "0x1882C5430")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x82C5580", Offset = "0x82C3F80", VA = "0x1882C5580")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x82C4F90", Offset = "0x82C3990", VA = "0x1882C4F90")]
	public void CopyBounds(SavedExtents EFNHKCDKOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x82C5380", Offset = "0x82C3D80", VA = "0x1882C5380")]
	public void SetLocalSpaceBounds(Bounds KEKLDAOAJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x16B42F0", Offset = "0x16B2CF0", VA = "0x1816B42F0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x82C5370", Offset = "0x82C3D70", VA = "0x1882C5370")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x82C4FC0", Offset = "0x82C39C0", VA = "0x1882C4FC0")]
	private void JMAGCGMJNNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x82C5170", Offset = "0x82C3B70", VA = "0x1882C5170")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x82C4920", Offset = "0x82C3320", VA = "0x1882C4920")]
	public static void CalculateLocalBoundsFor(GameObject CEENMGBCJEJ, [Out] Bounds KEKLDAOAJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x82C4860", Offset = "0x82C3260", VA = "0x1882C4860")]
	private static void COJGMPIIOIJ(Bounds ABNAHAKPDNC, Color HFDMMDBJNBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x82C53A0", Offset = "0x82C3DA0", VA = "0x1882C53A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1B6A010", Offset = "0x1B68A10", VA = "0x181B6A010")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5D78AC0", Offset = "0x5D774C0", VA = "0x185D78AC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public virtual void HMLEABLJKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
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
	[CAMOMJNCMBN]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5D786A0", Offset = "0x5D770A0", VA = "0x185D786A0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5D77390", Offset = "0x5D75D90", VA = "0x185D77390", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5D78A10", Offset = "0x5D77410", VA = "0x185D78A10")]
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
	private sealed class AJDHOLAJPNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public AJDHOLAJPNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5309390", Offset = "0x5307D90", VA = "0x185309390")]
		internal int HIDEOOGOBDN(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[CAMOMJNCMBN]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x49872A0", Offset = "0x4985CA0", VA = "0x1849872A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x49872F0", Offset = "0x4985CF0", VA = "0x1849872F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x49871A0", Offset = "0x4985BA0", VA = "0x1849871A0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey LNBCHJPEENA]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4987240", Offset = "0x4985C40", VA = "0x184987240", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4987080", Offset = "0x4985A80", VA = "0x184987080", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4986D90", Offset = "0x4985790", VA = "0x184986D90", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x49861D0", Offset = "0x4984BD0", VA = "0x1849861D0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4986140", Offset = "0x4984B40", VA = "0x184986140", Slot = "14")]
	protected virtual string JGBJMKCHINH(TKeyVal MICOBNLMBIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4986050", Offset = "0x4984A50", VA = "0x184986050", Slot = "4")]
	public bool ContainsKey(TKey LNBCHJPEENA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4986F40", Offset = "0x4985940", VA = "0x184986F40", Slot = "5")]
	public bool TryGetValue(TKey LNBCHJPEENA, [Out] TVal PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x49860A0", Offset = "0x4984AA0", VA = "0x1849860A0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x49860A0", Offset = "0x4984AA0", VA = "0x1849860A0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4986F90", Offset = "0x4985990", VA = "0x184986F90")]
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
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x48D4670", Offset = "0x48D3070", VA = "0x1848D4670")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[CAMOMJNCMBN]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5D7A2A0", Offset = "0x5D78CA0", VA = "0x185D7A2A0")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5D79B60", Offset = "0x5D78560", VA = "0x185D79B60", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5D79150", Offset = "0x5D77B50", VA = "0x185D79150", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class FLMELECLNNG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct BIONFNCLGPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T BHKLFFIKDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float JBBDGNLPDDL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int ELKFDDEIHJE = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float HIADLHDIPNC = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly BIONFNCLGPD[] JCEJMKLBKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int NNCDCMLPFMO;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float JAOCEPIPLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xD5C580", Offset = "0xD5AF80", VA = "0x180D5C580")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xDCD170", Offset = "0xDCBB70", VA = "0x180DCD170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T KIBADCDEBFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4E26810", Offset = "0x4E25210", VA = "0x184E26810")]
	protected FLMELECLNNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4E26830", Offset = "0x4E25230", VA = "0x184E26830")]
	protected FLMELECLNNG(int CGAAPEOHPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4E26650", Offset = "0x4E25050", VA = "0x184E26650")]
	public void MJGPLOFFIKO(float FPIFKAOGCDC, T PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool JIHMHGCONDK(float ABGKAAONMGB, float OMOENDBOKPL, [Out] T PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool EHFGKKMDAGI(float ABGKAAONMGB, float OMOENDBOKPL, [Out] T PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4E26580", Offset = "0x4E24F80", VA = "0x184E26580")]
	public void CHLOADNGFGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DNGNPDEFJJD : FLMELECLNNG<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x82C27B0", Offset = "0x82C11B0", VA = "0x1882C27B0", Slot = "4")]
	public override bool JIHMHGCONDK(float ABGKAAONMGB, float OMOENDBOKPL, [Out] Vector3 PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x82C2670", Offset = "0x82C1070", VA = "0x1882C2670", Slot = "5")]
	public override bool EHFGKKMDAGI(float ABGKAAONMGB, float OMOENDBOKPL, [Out] Vector3 PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x82C2910", Offset = "0x82C1310", VA = "0x1882C2910")]
	public DNGNPDEFJJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class ONLKBHDBEBL
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FA00", Offset = "0x3E4E400", VA = "0x183E4FA00")]
	public static HOHLNPEHAKD<T1, T2> OIDBKGGJJLH<T1, T2>(T1 PDFAPHEIODF, T2 JBEKDMKAGHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FA80", Offset = "0x3E4E480", VA = "0x183E4FA80")]
	public static IMCHKILJFEG<T1, T2, T3> OIDBKGGJJLH<T1, T2, T3>(T1 PDFAPHEIODF, T2 JBEKDMKAGHN, T3 KEGKCPHIING)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x587D9C0", Offset = "0x587C3C0", VA = "0x18587D9C0")]
	internal static int KCMOOMBGPKB(int IMGGIDDILFD, int BDJPMEJHMEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x743DB40", Offset = "0x743C540", VA = "0x18743DB40")]
	internal static int KCMOOMBGPKB(int IMGGIDDILFD, int BDJPMEJHMEK, int EOGEADNMFMI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HOHLNPEHAKD<T1, T2> : IComparable<HOHLNPEHAKD<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 JPMCEBFDNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 NNHCBIPCEJG;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5073F10", Offset = "0x5072910", VA = "0x185073F10")]
	public HOHLNPEHAKD(T1 PDFAPHEIODF, T2 JBEKDMKAGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5072390", Offset = "0x5070D90", VA = "0x185072390", Slot = "4")]
	public int CompareTo(HOHLNPEHAKD<T1, T2> EFNHKCDKOGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5072F50", Offset = "0x5071950", VA = "0x185072F50", Slot = "0")]
	public override bool Equals(object EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5073390", Offset = "0x5071D90", VA = "0x185073390", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5073AC0", Offset = "0x50724C0", VA = "0x185073AC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IMCHKILJFEG<T1, T2, T3> : IComparable<IMCHKILJFEG<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 JPMCEBFDNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 NNHCBIPCEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 CIOKFAHCMJN;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x516D930", Offset = "0x516C330", VA = "0x18516D930")]
	public IMCHKILJFEG(T1 PDFAPHEIODF, T2 JBEKDMKAGHN, T3 KEGKCPHIING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x516CFC0", Offset = "0x516B9C0", VA = "0x18516CFC0", Slot = "4")]
	public int CompareTo(IMCHKILJFEG<T1, T2, T3> EFNHKCDKOGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x516D240", Offset = "0x516BC40", VA = "0x18516D240", Slot = "0")]
	public override bool Equals(object EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x516D530", Offset = "0x516BF30", VA = "0x18516D530", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x516D660", Offset = "0x516C060", VA = "0x18516D660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AnimationCurve NAOICCPNGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T MFMPGBCHIDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x13D5B70", Offset = "0x13D4570", VA = "0x1813D5B70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T MLKOFMBHHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xD5CF80", Offset = "0xD5B980", VA = "0x180D5CF80")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T BHKLFFIKDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2E92EB0", Offset = "0x2E918B0", VA = "0x182E92EB0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2E92F80", Offset = "0x2E91980", VA = "0x182E92F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float KIMCDAPLFNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAD7480", Offset = "0xAD5E80", VA = "0x180AD7480")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x60436A0", Offset = "0x60420A0", VA = "0x1860436A0")]
	public T GDLNAAPNLAB(float JCAFCJGCHAJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6043340", Offset = "0x6041D40", VA = "0x186043340")]
	public T CDOHGPIIOEN(float JCAFCJGCHAJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BHKNOFHLECK(T HEOFBNHHDGF, T HEGCIIKIHGF, float JCAFCJGCHAJ);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x82C2A10", Offset = "0x82C1410", VA = "0x1882C2A10", Slot = "4")]
	protected override float BHKNOFHLECK(float HEOFBNHHDGF, float HEGCIIKIHGF, float JCAFCJGCHAJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x82C2A50", Offset = "0x82C1450", VA = "0x1882C2A50")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x19A2250", Offset = "0x19A0C50", VA = "0x1819A2250", Slot = "4")]
	protected override Vector3 BHKNOFHLECK(Vector3 HEOFBNHHDGF, Vector3 HEGCIIKIHGF, float JCAFCJGCHAJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x82C64F0", Offset = "0x82C4EF0", VA = "0x1882C64F0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x82C2570", Offset = "0x82C0F70", VA = "0x1882C2570", Slot = "4")]
	protected override Color BHKNOFHLECK(Color HEOFBNHHDGF, Color HEGCIIKIHGF, float JCAFCJGCHAJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x82C2630", Offset = "0x82C1030", VA = "0x1882C2630")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EFHNOJBNMBN : AFFEEHDLACO<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x82C29C0", Offset = "0x82C13C0", VA = "0x1882C29C0")]
	public EFHNOJBNMBN(int MOCOCCPAPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x82C2950", Offset = "0x82C1350", VA = "0x1882C2950", Slot = "6")]
	protected override uint OBMJBLCABJM(uint KEGBPMLIINA, string PDKJBMPOMNC)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CPMIOPDCLCN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable NDAIDGNOFDA;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public CPMIOPDCLCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct EKLCILNNNKM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> AFIKDMEAAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int DBHGLHKDMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int GIABBPCEGCA;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4945210", Offset = "0x4943C10", VA = "0x184945210")]
	private EKLCILNNNKM(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> HLEJPBEPJLP, int KEHJBGLNLHF, int DNFBLPBKMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4945110", Offset = "0x4943B10", VA = "0x184945110")]
	public static EKLCILNNNKM<T> MDDJOGPLAFO()
	{
		return default(EKLCILNNNKM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4943CD0", Offset = "0x49426D0", VA = "0x184943CD0")]
	public (int, int, Task<T>) HBJJBPGMCCC(int FCNHLPKGBDC, [Optional] CancellationToken OMJKEHOJJFF, double NMPFLEBOLHH = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x49432A0", Offset = "0x4941CA0", VA = "0x1849432A0")]
	public void CNLNEOJEFKN(int FCNHLPKGBDC, int DNFBLPBKMLL, [In] T AEAMJGPOBKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class JNIKPJMEBMI
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x82C2BA0", Offset = "0x82C15A0", VA = "0x1882C2BA0")]
	public static EKLCILNNNKM<FAIGCFGAAKD> MDDJOGPLAFO()
	{
		return default(EKLCILNNNKM<FAIGCFGAAKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x82C2B20", Offset = "0x82C1520", VA = "0x1882C2B20")]
	public static void CNLNEOJEFKN([In] this EKLCILNNNKM<FAIGCFGAAKD> NLDLHIJAJBO, int FCNHLPKGBDC, int DNFBLPBKMLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class BALMIJFADEC<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> FPBEHEFLHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> OACKCCGIPMM;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4488F50", Offset = "0x4487950", VA = "0x184488F50", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool CLDNKONDKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> IMDDKDHGJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4E2EE90", Offset = "0x4E2D890", VA = "0x184E2EE90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> MFALEKJCBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x64ADBE0", Offset = "0x64AC5E0", VA = "0x1864ADBE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x64ADB80", Offset = "0x64AC580", VA = "0x1864ADB80", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x64ADC40", Offset = "0x64AC640", VA = "0x1864ADC40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x64AD700", Offset = "0x64AC100", VA = "0x1864AD700")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x64AD360", Offset = "0x64ABD60", VA = "0x1864AD360", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x64ADA00", Offset = "0x64AC400", VA = "0x1864ADA00", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x64AD110", Offset = "0x64ABB10", VA = "0x1864AD110", Slot = "9")]
	public void Add(TKey LNBCHJPEENA, TVal PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x64AD160", Offset = "0x64ABB60", VA = "0x1864AD160", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> HNLFGCKBFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x64AD3C0", Offset = "0x64ABDC0", VA = "0x1864AD3C0", Slot = "8")]
	public bool ContainsKey(TKey LNBCHJPEENA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x64AD430", Offset = "0x64ABE30", VA = "0x1864AD430", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x64AD920", Offset = "0x64AC320", VA = "0x1864AD920", Slot = "10")]
	public bool Remove(TKey LNBCHJPEENA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x64AD950", Offset = "0x64AC350", VA = "0x1864AD950", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x64ADA50", Offset = "0x64AC450", VA = "0x1864ADA50", Slot = "11")]
	public bool TryGetValue(TKey LNBCHJPEENA, [Out] TVal PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x64AD610", Offset = "0x64AC010", VA = "0x1864AD610", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x64AD460", Offset = "0x64ABE60", VA = "0x1864AD460", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] JCEJMKLBKKB, int MDMGHHNAEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x64AD880", Offset = "0x64AC280", VA = "0x1864AD880")]
	public bool PKNEHCKDABA(TVal LNBCHJPEENA, [Out] TKey PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x64AD570", Offset = "0x64ABF70", VA = "0x1864AD570")]
	private void EAGBOLMGFGP(TKey LNBCHJPEENA, TVal BEAEDIJJJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x64AD7E0", Offset = "0x64AC1E0", VA = "0x1864AD7E0")]
	private void LAAGKAMHPEB(TKey LNBCHJPEENA, TVal BEAEDIJJJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x64AD280", Offset = "0x64ABC80", VA = "0x1864AD280")]
	private bool CNCFPMENFMD(TKey LNBCHJPEENA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x64ADA90", Offset = "0x64AC490", VA = "0x1864ADA90")]
	public BALMIJFADEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class JOOLDAFNLND<T> : IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private JOOLDAFNLND<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x49E1820", Offset = "0x49E0220", VA = "0x1849E1820", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x49ECE30", Offset = "0x49EB830", VA = "0x1849ECE30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x49EDB50", Offset = "0x49EC550", VA = "0x1849EDB50")]
		public Enumerator(JOOLDAFNLND<T> AEJOONCILAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x49EBC00", Offset = "0x49EA600", VA = "0x1849EBC00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x49EC820", Offset = "0x49EB220", VA = "0x1849EC820", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x49EC620", Offset = "0x49EB020", VA = "0x1849EC620")]
		private void PIOPKLNKBIA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] MMJBIBLKAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int EMMDOKDGNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int LDBMCCHNJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int OHBCMIBMOPM;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5430960", Offset = "0x542F360", VA = "0x185430960", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x542EA40", Offset = "0x542D440", VA = "0x18542EA40")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x542E720", Offset = "0x542D120", VA = "0x18542E720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x54308E0", Offset = "0x542F2E0", VA = "0x1854308E0")]
	public JOOLDAFNLND(int MOCOCCPAPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x542ED40", Offset = "0x542D740", VA = "0x18542ED40")]
	public void MJGPLOFFIKO(T JCAFCJGCHAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x542FEB0", Offset = "0x542E8B0", VA = "0x18542FEB0")]
	public void MOENCCMOPDH(IEnumerable<T> OPPACCCPKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x542DEF0", Offset = "0x542C8F0", VA = "0x18542DEF0")]
	public void CHLOADNGFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x542DE40", Offset = "0x542C840", VA = "0x18542DE40")]
	public void CDHKDLMCINK(int CDCPIGCEABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x542D710", Offset = "0x542C110", VA = "0x18542D710")]
	public void ACFCGPIAPCE(T[] JCEJMKLBKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x542E980", Offset = "0x542D380", VA = "0x18542E980")]
	public Enumerator IBBMHAHFLHH()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5430720", Offset = "0x542F120", VA = "0x185430720", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5430720", Offset = "0x542F120", VA = "0x185430720", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x542E270", Offset = "0x542CC70", VA = "0x18542E270")]
	private int GNAGJAGAJJN(int FILGHJLFKAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x542DF10", Offset = "0x542C910", VA = "0x18542DF10")]
	private int COGDBKPOPDH(int FILGHJLFKAL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OPLDLGECPOF<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> MDGOCPKAJPO(TRequest NIBLEOGJBJF, CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum HMDDJLEGHMF
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class KABMPHOFPLN
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float OKHNIIKBKNA = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan LBLKDFPKBEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int FICKKNMKKGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public HMDDJLEGHMF FFDIKPHDOID;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly KABMPHOFPLN MDAKIDAOHEC;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float ADLJJKFLLLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x54D9680", Offset = "0x54D8080", VA = "0x1854D9680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan LBFECEBDOJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x54D97D0", Offset = "0x54D81D0", VA = "0x1854D97D0")]
		public KABMPHOFPLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct FEJHJDMABCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest NIBLEOGJBJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken OMJKEHOJJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> NDACGEPCIDJ;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4DF60F0", Offset = "0x4DF4AF0", VA = "0x184DF60F0")]
		public FEJHJDMABCN(TRequest NIBLEOGJBJF, TaskCompletionSource<TResult> NDACGEPCIDJ, CancellationToken OMJKEHOJJFF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct NLDOLEFJKMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public OPLDLGECPOF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x58D70E0", Offset = "0x58D5AE0", VA = "0x1858D70E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x58D78A0", Offset = "0x58D62A0", VA = "0x1858D78A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct NOHAOIKGEAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public OPLDLGECPOF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private FEJHJDMABCN <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x58DE060", Offset = "0x58DCA60", VA = "0x1858DE060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x58DE600", Offset = "0x58DD000", VA = "0x1858DE600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource JLBADPKPEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<FEJHJDMABCN> NGGJADHCIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly KABMPHOFPLN JPNECHIEBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MDGOCPKAJPO AEILNOGLKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task HNBOABPMNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int FGAGMPBFHDC;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5A39910", Offset = "0x5A38310", VA = "0x185A39910")]
	public OPLDLGECPOF(MDGOCPKAJPO AEILNOGLKMH, [Optional] KABMPHOFPLN JPNECHIEBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5A37DB0", Offset = "0x5A367B0", VA = "0x185A37DB0")]
	public Task<TResult> CJMEFDDHHKN(TRequest NIBLEOGJBJF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5A392A0", Offset = "0x5A37CA0", VA = "0x185A392A0")]
	private void EJNFBGIFODA(FEJHJDMABCN PJCMKDAMCGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5A39040", Offset = "0x5A37A40", VA = "0x185A39040")]
	[AsyncStateMachine(typeof(OPLDLGECPOF<, >.NLDOLEFJKMC))]
	private Task DNIOEOKHMNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5A38680", Offset = "0x5A37080", VA = "0x185A38680")]
	private FEJHJDMABCN CPJKGNANADD()
	{
		return default(FEJHJDMABCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5A38BC0", Offset = "0x5A375C0", VA = "0x185A38BC0")]
	[AsyncStateMachine(typeof(OPLDLGECPOF<, >.NOHAOIKGEAH))]
	private Task DJOHGEFJAKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5A39430", Offset = "0x5A37E30", VA = "0x185A39430")]
	private void HGGOKJPJGNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5A39110", Offset = "0x5A37B10", VA = "0x185A39110", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface IRRUISpriteLookup
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryFindSpriteByName(string spriteName, [Out] Sprite sprite);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class FEHGFMOIBEG<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> CKDFPBCCFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> KHKBFPADKIG;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4488F50", Offset = "0x4487950", VA = "0x184488F50", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool CLDNKONDKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4DEE810", Offset = "0x4DED210", VA = "0x184DEE810", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4DF5980", Offset = "0x4DF4380", VA = "0x184DF5980", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4DF5020", Offset = "0x4DF3A20", VA = "0x184DF5020", Slot = "11")]
	public void Add(T HNLFGCKBFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4DF5470", Offset = "0x4DF3E70", VA = "0x184DF5470")]
	public bool NKALLCACMDG(T HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4DF5720", Offset = "0x4DF4120", VA = "0x184DF5720", Slot = "15")]
	public bool Remove(T HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4DF5110", Offset = "0x4DF3B10", VA = "0x184DF5110", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4DF5860", Offset = "0x4DF4260", VA = "0x184DF5860", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4DF5040", Offset = "0x4DF3A40", VA = "0x184DF5040", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4DF50A0", Offset = "0x4DF3AA0", VA = "0x184DF50A0", Slot = "13")]
	public bool Contains(T HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4DF50E0", Offset = "0x4DF3AE0", VA = "0x184DF50E0", Slot = "14")]
	public void CopyTo(T[] JCEJMKLBKKB, int MDMGHHNAEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4DF51A0", Offset = "0x4DF3BA0", VA = "0x184DF51A0", Slot = "6")]
	public int IndexOf(T HNLFGCKBFGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4DF51F0", Offset = "0x4DF3BF0", VA = "0x184DF51F0", Slot = "7")]
	public void Insert(int FILGHJLFKAL, T HNLFGCKBFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4DF5630", Offset = "0x4DF4030", VA = "0x184DF5630", Slot = "8")]
	public void RemoveAt(int FILGHJLFKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4DF5890", Offset = "0x4DF4290", VA = "0x184DF5890")]
	public FEHGFMOIBEG()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2D08060", Offset = "0x2D06A60", VA = "0x182D08060")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x82C5A40", Offset = "0x82C4440", VA = "0x1882C5A40")]
		public SerializedGuid([In] Guid DNLDANFOOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x82C58B0", Offset = "0x82C42B0", VA = "0x1882C58B0")]
		public static SerializedGuid JBEHOJILMJG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x82C5730", Offset = "0x82C4130", VA = "0x1882C5730")]
		public static SerializedGuid BCGDBIEKNEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x82C5930", Offset = "0x82C4330", VA = "0x1882C5930")]
		public bool OFLDDHIICNG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x82C5A10", Offset = "0x82C4410", VA = "0x1882C5A10", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x82C5990", Offset = "0x82C4390", VA = "0x1882C5990", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x82C57D0", Offset = "0x82C41D0", VA = "0x1882C57D0", Slot = "7")]
		public bool Equals(SerializedGuid EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x82C5810", Offset = "0x82C4210", VA = "0x1882C5810", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x82C58A0", Offset = "0x82C42A0", VA = "0x1882C58A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x82C57A0", Offset = "0x82C41A0", VA = "0x1882C57A0", Slot = "6")]
		public int CompareTo(SerializedGuid EFNHKCDKOGH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class AMBDOKIBFFB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type NCHCKKAJMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string JEKBDCDEKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool GLAJOCKCCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool FCMPFMPNHAN;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x82C1710", Offset = "0x82C0110", VA = "0x1882C1710")]
	public AMBDOKIBFFB(Type LJINPHEJHLD, string DANMIDBIPLL, bool LBENBEIMEEC = false, bool EPPKMNGHPBB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface JCBHJPINMEK<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int BOMNIOOPBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> PHGEHGGBALM(float FPIFKAOGCDC, [Optional] float? AMAINCIIJFK);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LADLMFNPPDE(float FPIFKAOGCDC, T PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CHLOADNGFGM();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class LKPBJHELICL<T> : JCBHJPINMEK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class CIIDDBBDGCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float POFCFOMDDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T BHKLFFIKDPE;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public CIIDDBBDGCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class JPBNJMOJMCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public JPBNJMOJMCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5431180", Offset = "0x542FB80", VA = "0x185431180")]
		internal bool JCOCMCPOLOB(CIIDDBBDGCE sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float EAOMBDBAIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float ELIOHEHMGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<CIIDDBBDGCE> HOJPNGNMCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private GAJJEGFOAHO<CIIDDBBDGCE> NKLCBHBBOHE;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int BOMNIOOPBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x561A690", Offset = "0x5619090", VA = "0x18561A690", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x561AD60", Offset = "0x5619760", VA = "0x18561AD60")]
	public LKPBJHELICL(float FIPPEEMJJJN, float HKAPIBCHGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x561A490", Offset = "0x5618E90", VA = "0x18561A490", Slot = "6")]
	public bool LADLMFNPPDE(float FPIFKAOGCDC, T PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x561AA30", Offset = "0x5619430", VA = "0x18561AA30", Slot = "5")]
	public IEnumerable<T> PHGEHGGBALM(float FPIFKAOGCDC, float? AMAINCIIJFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x561A140", Offset = "0x5618B40", VA = "0x18561A140", Slot = "7")]
	public void CHLOADNGFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x561A1B0", Offset = "0x5618BB0", VA = "0x18561A1B0")]
	private void IAGELGOECFK(float FPIFKAOGCDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class ICKLMKHDBBP<T> : JCBHJPINMEK<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct LFALLNOCFMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T BHKLFFIKDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float POFCFOMDDEN;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x53E0660", Offset = "0x53DF060", VA = "0x1853E0660")]
		public LFALLNOCFMA(T PDKJBMPOMNC, float FPIFKAOGCDC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class DNLCDKLGLGB : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ICKLMKHDBBP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float <>3__time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private float? minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float? <>3__minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private int <count>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xFEC320", Offset = "0xFEAD20", VA = "0x180FEC320")]
		[DebuggerHidden]
		public DNLCDKLGLGB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x703E310", Offset = "0x703CD10", VA = "0x18703E310", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x703E810", Offset = "0x703D210", VA = "0x18703E810", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x703E640", Offset = "0x703D040", VA = "0x18703E640", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x501D700", Offset = "0x501C100", VA = "0x18501D700", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float FIPPEEMJJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float HKAPIBCHGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<LFALLNOCFMA> HOJPNGNMCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int EMMDOKDGNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int JIMJFFPLELB;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int BOMNIOOPBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5B0", Offset = "0xA8CFB0", VA = "0x180A8E5B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x511CC90", Offset = "0x511B690", VA = "0x18511CC90")]
	public ICKLMKHDBBP(float FIPPEEMJJJN, float HKAPIBCHGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x511C680", Offset = "0x511B080", VA = "0x18511C680", Slot = "6")]
	public bool LADLMFNPPDE(float FPIFKAOGCDC, T PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x511C8F0", Offset = "0x511B2F0", VA = "0x18511C8F0", Slot = "8")]
	public int NBHNBLDAPPI(float FPIFKAOGCDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x511C9D0", Offset = "0x511B3D0", VA = "0x18511C9D0", Slot = "5")]
	[IteratorStateMachine(typeof(ICKLMKHDBBP<>.DNLCDKLGLGB))]
	public IEnumerable<T> PHGEHGGBALM(float FPIFKAOGCDC, float? AMAINCIIJFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x511C0E0", Offset = "0x511AAE0", VA = "0x18511C0E0", Slot = "7")]
	public void CHLOADNGFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x511C1E0", Offset = "0x511ABE0", VA = "0x18511C1E0")]
	private void FBFEANELJDE(float FPIFKAOGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x511C2C0", Offset = "0x511ACC0", VA = "0x18511C2C0")]
	private LFALLNOCFMA FPMKBPNCADJ()
	{
		return default(LFALLNOCFMA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class OGMJCPNEHOO<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct MGPMDJJBCNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long HEPHMEHBDGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long JMPEDJHBNFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int OPOKBCNKNKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int JNPGKNIMHOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool ODGLKFOIECF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string NBOBJDCEEMI;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x58287A0", Offset = "0x58271A0", VA = "0x1858287A0")]
		public MGPMDJJBCNH(long HEPHMEHBDGH, int OPOKBCNKNKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5828810", Offset = "0x5827210", VA = "0x185828810")]
		public MGPMDJJBCNH(long HEPHMEHBDGH, long JMPEDJHBNFG, int OPOKBCNKNKK, int JNPGKNIMHOP, bool ODGLKFOIECF, string NBOBJDCEEMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5828730", Offset = "0x5827130", VA = "0x185828730")]
		public int MLCCNLMAKMI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5828780", Offset = "0x5827180", VA = "0x185828780")]
		public int PFLEOELIBFD(int HDGHIAOLCGG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x58286D0", Offset = "0x58270D0", VA = "0x1858286D0")]
		public double MCGHALJLDAA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5828630", Offset = "0x5827030", VA = "0x185828630")]
		public MGPMDJJBCNH HFJABEAGHEJ(long JMPEDJHBNFG, int JNPGKNIMHOP)
		{
			return default(MGPMDJJBCNH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class LOEEEDILNMC : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct ENJGAJANABA<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public LOEEEDILNMC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<LOEEEDILNMC, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private LOEEEDILNMC <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x4947800", Offset = "0x4946200", VA = "0x184947800", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x4947CC0", Offset = "0x49466C0", VA = "0x184947CC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey OFFMBGPIJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly OGMJCPNEHOO<TKey> HIBNALIEBDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly MEBJEIOEDLD HJHMNJLNNBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<LOEEEDILNMC> JPLHJPOKCAK;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string PLLNJICDBCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x5624500", Offset = "0x5622F00", VA = "0x185624500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<LOEEEDILNMC> PGBFILJDFEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x56244A0", Offset = "0x5622EA0", VA = "0x1856244A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public MGPMDJJBCNH CGLLOLFLFED
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x56244E0", Offset = "0x5622EE0", VA = "0x1856244E0")]
			[CompilerGenerated]
			get
			{
				return default(MGPMDJJBCNH);
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x5624530", Offset = "0x5622F30", VA = "0x185624530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5624560", Offset = "0x5622F60", VA = "0x185624560")]
		internal LOEEEDILNMC(OGMJCPNEHOO<TKey> HIBNALIEBDI, TKey LNBCHJPEENA, MEBJEIOEDLD HJHMNJLNNBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5624140", Offset = "0x5622B40", VA = "0x185624140")]
		public LOEEEDILNMC DPKFDDEOPND(TKey LNBCHJPEENA, [Optional] MEBJEIOEDLD? BAIFHIGCKOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4406DC0", Offset = "0x44057C0", VA = "0x184406DC0")]
		[AsyncStateMachine(typeof(ENJGAJANABA<>))]
		public Task<T> LFLFCLIPLKM<T>(TKey LNBCHJPEENA, Func<LOEEEDILNMC, Task<T>> JENFFPGIJNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x56242A0", Offset = "0x5622CA0", VA = "0x1856242A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class NLFFENLMNKN : IEnumerable<(TKey, List<TKey>, MGPMDJJBCNH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, MGPMDJJBCNH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, MGPMDJJBCNH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public OGMJCPNEHOO<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, MGPMDJJBCNH timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, MGPMDJJBCNH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x2CFC290", Offset = "0x2CFAC90", VA = "0x182CFC290", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, MGPMDJJBCNH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x58D7EB0", Offset = "0x58D68B0", VA = "0x1858D7EB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2CFC380", Offset = "0x2CFAD80", VA = "0x182CFC380")]
		[DebuggerHidden]
		public NLFFENLMNKN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4E9BC70", Offset = "0x4E9A670", VA = "0x184E9BC70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x58D7A10", Offset = "0x58D6410", VA = "0x1858D7A10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x58D79C0", Offset = "0x58D63C0", VA = "0x1858D79C0")]
		private void ALLLMJKJJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x58D7E60", Offset = "0x58D6860", VA = "0x1858D7E60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x58D7DA0", Offset = "0x58D67A0", VA = "0x1858D7DA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, MGPMDJJBCNH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x44AB5B0", Offset = "0x44A9FB0", VA = "0x1844AB5B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class HLIGGBDCELL : IEnumerable<(TKey, List<TKey>, MGPMDJJBCNH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, MGPMDJJBCNH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, MGPMDJJBCNH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private LOEEEDILNMC timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public LOEEEDILNMC <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public OGMJCPNEHOO<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<LOEEEDILNMC> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, MGPMDJJBCNH timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, MGPMDJJBCNH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2CFC290", Offset = "0x2CFAC90", VA = "0x182CFC290", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, MGPMDJJBCNH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x5057B80", Offset = "0x5056580", VA = "0x185057B80", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2CFC380", Offset = "0x2CFAD80", VA = "0x182CFC380")]
		[DebuggerHidden]
		public HLIGGBDCELL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5057BE0", Offset = "0x50565E0", VA = "0x185057BE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5057220", Offset = "0x5055C20", VA = "0x185057220", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x50571C0", Offset = "0x5055BC0", VA = "0x1850571C0")]
		private void ALLLMJKJJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x50579C0", Offset = "0x50563C0", VA = "0x1850579C0")]
		private void NADPDCNBFDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5057B30", Offset = "0x5056530", VA = "0x185057B30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5057A20", Offset = "0x5056420", VA = "0x185057A20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, MGPMDJJBCNH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5057B00", Offset = "0x5056500", VA = "0x185057B00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, MGPMDJJBCNH, MEBJEIOEDLD> BIILBOHEIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, MGPMDJJBCNH, MEBJEIOEDLD> BNOHAFFMDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<OGMJCPNEHOO<TKey>, MEBJEIOEDLD> ODDHNFIABMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly LOEEEDILNMC PIEKOJLIGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool JNAAJFKIBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int HPMGABCALIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch OLKFHOBKNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int GBCDGIIGEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string GILJOFFOJJK;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public LOEEEDILNMC PPPEDBFDMLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string PLLNJICDBCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82C10", VA = "0x180A84210")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5A03270", Offset = "0x5A01C70", VA = "0x185A03270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5A03350", Offset = "0x5A01D50", VA = "0x185A03350")]
	public OGMJCPNEHOO(TKey EDMMOONCGNE, MEBJEIOEDLD HJHMNJLNNBM, [Optional] int? OPOKBCNKNKK, [Optional][CanBeNull] Stopwatch OLKFHOBKNOE, [Optional] Action<TKey, MGPMDJJBCNH, MEBJEIOEDLD> BIILBOHEIKA, [Optional] Action<TKey, MGPMDJJBCNH, MEBJEIOEDLD> BNOHAFFMDEI, [Optional] Action<OGMJCPNEHOO<TKey>, MEBJEIOEDLD> ODDHNFIABMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5A03080", Offset = "0x5A01A80", VA = "0x185A03080", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5A03110", Offset = "0x5A01B10", VA = "0x185A03110")]
	[IteratorStateMachine(typeof(OGMJCPNEHOO<>.NLFFENLMNKN))]
	public IEnumerable<(TKey, List<TKey>, MGPMDJJBCNH)> ELKCOKDANHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5A031A0", Offset = "0x5A01BA0", VA = "0x185A031A0")]
	[IteratorStateMachine(typeof(OGMJCPNEHOO<>.HLIGGBDCELL))]
	private IEnumerable<(TKey, List<TKey>, MGPMDJJBCNH)> ELKCOKDANHG(List<TKey> HODLOHIDPMG, LOEEEDILNMC KEEEDCAGGGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5A032D0", Offset = "0x5A01CD0", VA = "0x185A032D0")]
	private (long, int) NBPJOLELAIO()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class KEENCIIKFKO<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut AEJKPAJKGKO(OGMJCPNEHOO<TKey> HIBNALIEBDI);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	protected KEENCIIKFKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class MPEAFOLMIMK<TKey> : KEENCIIKFKO<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate string MOCKEAKGPDO(TKey LNBCHJPEENA);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x584D9A0", Offset = "0x584C3A0", VA = "0x18584D9A0")]
	private static string OEOFEIJDDFM(TKey LNBCHJPEENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x584D790", Offset = "0x584C190", VA = "0x18584D790", Slot = "4")]
	public override string AEJKPAJKGKO(OGMJCPNEHOO<TKey> HIBNALIEBDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x584D850", Offset = "0x584C250", VA = "0x18584D850")]
	public string AEJKPAJKGKO(OGMJCPNEHOO<TKey> HIBNALIEBDI, [NotNull] MOCKEAKGPDO AGCIEOONOAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string ELHFDPEBOGE(OGMJCPNEHOO<TKey> HIBNALIEBDI, [NotNull] MOCKEAKGPDO AGCIEOONOAA);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x492DEC0", Offset = "0x492C8C0", VA = "0x18492DEC0")]
	protected MPEAFOLMIMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class DOJEPDKJJFA<TKey> : KEENCIIKFKO<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate string ECLEEKHMMPO(TKey LNBCHJPEENA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string FBMFFGNBDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double LNBOOKBNPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool MPJBHPLIBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int NCHMGIDKFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> ACBKEILFNKK;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x44996A0", Offset = "0x44980A0", VA = "0x1844996A0")]
	private static string OEOFEIJDDFM(TKey LNBCHJPEENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x44996E0", Offset = "0x44980E0", VA = "0x1844996E0")]
	public DOJEPDKJJFA(string FBMFFGNBDNB = "F2", double LNBOOKBNPPH = double.MaxValue, bool MPJBHPLIBID = false, int NCHMGIDKFBD = int.MaxValue, [Optional] ISet<string> ACBKEILFNKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4499160", Offset = "0x4497B60", VA = "0x184499160", Slot = "4")]
	public override Dictionary<string, string> AEJKPAJKGKO(OGMJCPNEHOO<TKey> HIBNALIEBDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4499220", Offset = "0x4497C20", VA = "0x184499220")]
	private bool CFLBGNKIALE(string HKGGHJHGONF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4498B70", Offset = "0x4497570", VA = "0x184498B70")]
	public Dictionary<string, string> AEJKPAJKGKO(OGMJCPNEHOO<TKey> HIBNALIEBDI, ECLEEKHMMPO AGCIEOONOAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x4499300", Offset = "0x4497D00", VA = "0x184499300")]
	private string MMLGHGKAJAG(StringBuilder GPHKBMJGIEP, List<TKey> BDKAFGPCILE, ECLEEKHMMPO AGCIEOONOAA, bool HPGNDKCPKKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4499540", Offset = "0x4497F40", VA = "0x184499540")]
	private static void NPECCKKJGIP(StringBuilder NJNKMLIHEEJ, string KBBFEKKFFKJ, bool FAFCEMLLAHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class COIAPPKILBO<TKey> : MPEAFOLMIMK<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct LMFMCIKGJBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public MOCKEAKGPDO keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static COIAPPKILBO<TKey> NDAIDGNOFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] KHLCDFLJGGF;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6A4F010", Offset = "0x6A4DA10", VA = "0x186A4F010")]
	private COIAPPKILBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DFB0", Offset = "0x6A4C9B0", VA = "0x186A4DFB0", Slot = "5")]
	protected override string ELHFDPEBOGE(OGMJCPNEHOO<TKey> HIBNALIEBDI, MOCKEAKGPDO AGCIEOONOAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6A4EDE0", Offset = "0x6A4D7E0", VA = "0x186A4EDE0")]
	[CompilerGenerated]
	internal static string JOEMNGFLCNB(string FGGJIHFGDGB, TKey LNBCHJPEENA, LMFMCIKGJBF P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class CEAACFBKOIM : OGMJCPNEHOO<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class HPCGECGAOJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<CEAACFBKOIM, MEBJEIOEDLD> callback;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public HPCGECGAOJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x82C2A90", Offset = "0x82C1490", VA = "0x1882C2A90")]
		internal void BOAIFLAKMBL(OGMJCPNEHOO<string> timer, MEBJEIOEDLD log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x82C2250", Offset = "0x82C0C50", VA = "0x1882C2250")]
	public CEAACFBKOIM(MEBJEIOEDLD HJHMNJLNNBM, [Optional] string IPCDEBGMMKL, [Optional] int? OPOKBCNKNKK, [Optional] Stopwatch OLKFHOBKNOE, [Optional] Action<string, MGPMDJJBCNH, MEBJEIOEDLD> BIILBOHEIKA, [Optional] Action<string, MGPMDJJBCNH, MEBJEIOEDLD> BNOHAFFMDEI, [Optional] Action<CEAACFBKOIM, MEBJEIOEDLD> ODDHNFIABMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x82C2190", Offset = "0x82C0B90", VA = "0x1882C2190")]
	private static Action<OGMJCPNEHOO<string>, MEBJEIOEDLD> BANEKPHAKMP(Action<CEAACFBKOIM, MEBJEIOEDLD> EMBEDGKMMHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public abstract class KDFCKBEIDLF
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class NFEAAFCCFCN : KDFCKBEIDLF
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static KDFCKBEIDLF NDAIDGNOFDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x82C2D60", Offset = "0x82C1760", VA = "0x1882C2D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float PDNLCBOHEHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x136C9D0", Offset = "0x136B3D0", VA = "0x18136C9D0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x82C2E60", Offset = "0x82C1860", VA = "0x1882C2E60")]
		public NFEAAFCCFCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static KDFCKBEIDLF KIPNLAMKIFP;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static KDFCKBEIDLF MDAKIDAOHEC
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x82C2BF0", Offset = "0x82C15F0", VA = "0x1882C2BF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float PDNLCBOHEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	protected KDFCKBEIDLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface OMAHFCAPHPN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool HCIBKCBAOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface FDLGIOOGFEJ<T> : OMAHFCAPHPN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> BDPBBCLCMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	DPMDGLGHBHJ<T> MMBOOOFMKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class IIKOKDLPPEL
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3CB5460", Offset = "0x3CB3E60", VA = "0x183CB5460")]
	public static FDLGIOOGFEJ<TResource> CECOIKCOKHP<TResource, TId>(this JEIBALHAAGC<TId, TResource> FNLAOKPMGLM, TId EGJGKBPPPFG, [Optional] Func<TId, CancellationToken, Task<TResource>>? HHLILKEEEPL) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class KDJOGCHJIFA
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class OAJENKNAGKG<T> : MKJJOFDHLJK<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> BDPBBCLCMMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override DPMDGLGHBHJ<T?> MMBOOOFMKKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x59EE800", Offset = "0x59ED200", VA = "0x1859EE800")]
		public OAJENKNAGKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "10")]
		protected override void BLALHCGAKEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class CKAJDIDPAJG<T> : MKJJOFDHLJK<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T HHJGNNILLAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? KIEJMFMAFED;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> BDPBBCLCMMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override DPMDGLGHBHJ<T> MMBOOOFMKKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6A47BE0", Offset = "0x6A465E0", VA = "0x186A47BE0")]
		public CKAJDIDPAJG(T AJDKAFGCBHO, Action<T>? KBMFALAJOBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x6A47B90", Offset = "0x6A46590", VA = "0x186A47B90", Slot = "10")]
		protected override void BLALHCGAKEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class EAPLDFINLAP<T> : MKJJOFDHLJK<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> BDPBBCLCMMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override DPMDGLGHBHJ<T> MMBOOOFMKKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x490A470", Offset = "0x4908E70", VA = "0x18490A470")]
		public EAPLDFINLAP(Exception KOFGEHMDLMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "10")]
		protected override void BLALHCGAKEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private sealed class EIDNMPFJKJK<T> : MKJJOFDHLJK<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct JIFMCDAEHMO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<FDLGIOOGFEJ<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<FDLGIOOGFEJ<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x53DBD50", Offset = "0x53DA750", VA = "0x1853DBD50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x53DC750", Offset = "0x53DB150", VA = "0x1853DC750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct OBLCIOGDAIO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<FDLGIOOGFEJ<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<FDLGIOOGFEJ<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x59F6AD0", Offset = "0x59F54D0", VA = "0x1859F6AD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x59F6D00", Offset = "0x59F5700", VA = "0x1859F6D00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<FDLGIOOGFEJ<T>> CHEIAAKKFMI;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> BDPBBCLCMMN
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override DPMDGLGHBHJ<T> MMBOOOFMKKG
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4938410", Offset = "0x4936E10", VA = "0x184938410")]
		public EIDNMPFJKJK(Task<FDLGIOOGFEJ<T>> AIPCFMDLKCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x4937E50", Offset = "0x4936850", VA = "0x184937E50", Slot = "10")]
		protected override void BLALHCGAKEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x49380D0", Offset = "0x4936AD0", VA = "0x1849380D0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(EIDNMPFJKJK<>.JIFMCDAEHMO))]
		internal static Task<T> KAMIEPIBENJ(Task<FDLGIOOGFEJ<T>> AIPCFMDLKCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x4938230", Offset = "0x4936C30", VA = "0x184938230")]
		[AsyncStateMachine(typeof(EIDNMPFJKJK<>.OBLCIOGDAIO))]
		[CompilerGenerated]
		internal static Task OELAHFMAODG(Task<FDLGIOOGFEJ<T>> AIPCFMDLKCK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class EINEKAFAIOH<TIn, TOut> : MKJJOFDHLJK<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct OEPLCCELLIN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x59FF6A0", Offset = "0x59FE0A0", VA = "0x1859FF6A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x4DFC4C0", Offset = "0x4DFAEC0", VA = "0x184DFC4C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly FDLGIOOGFEJ<TIn> NNKHFIDEHIO;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> BDPBBCLCMMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override DPMDGLGHBHJ<TOut> MMBOOOFMKKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x4939290", Offset = "0x4937C90", VA = "0x184939290")]
		public EINEKAFAIOH(FDLGIOOGFEJ<TIn> ENCEOHAIGEG, Func<TIn, TOut> OPEANBDKOGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4938EF0", Offset = "0x49378F0", VA = "0x184938EF0", Slot = "10")]
		protected override void BLALHCGAKEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x4938F90", Offset = "0x4937990", VA = "0x184938F90")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(EINEKAFAIOH<, >.OEPLCCELLIN))]
		internal static Task<TOut> IKLNLCPJJBH(Task<TIn> NGMMBLPMFAL, Func<TIn, TOut> OPEANBDKOGJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3D2A190", Offset = "0x3D28B90", VA = "0x183D2A190")]
	public static FDLGIOOGFEJ<T> MFNPHNGAJMG<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3D2A100", Offset = "0x3D28B00", VA = "0x183D2A100")]
	public static FDLGIOOGFEJ<T> ELLDPKAFDHE<T>(T AEAMJGPOBKI, [Optional] Action<T>? KBMFALAJOBF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3C75FA0", Offset = "0x3C749A0", VA = "0x183C75FA0")]
	public static FDLGIOOGFEJ<T> NPKIDECKMPI<T>(Exception KOFGEHMDLMC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3C75FA0", Offset = "0x3C749A0", VA = "0x183C75FA0")]
	public static FDLGIOOGFEJ<T> PDIAJJHJPAB<T>(Task<FDLGIOOGFEJ<T>> AIPCFMDLKCK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3AD8CA0", Offset = "0x3AD76A0", VA = "0x183AD8CA0")]
	public static FDLGIOOGFEJ<TOut> AMPAFLPNFEK<TOut, TIn>(FDLGIOOGFEJ<TIn> OFBHFOIEGGG, Func<TIn, TOut> OPEANBDKOGJ) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class MKJJOFDHLJK<T> : FDLGIOOGFEJ<T>, OMAHFCAPHPN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string LCPBCFKNOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly HGNCEMOPDGA DKJONPFNCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool JNAAJFKIBLB;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool HCIBKCBAOCE
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xB50B30", Offset = "0xB4F530", VA = "0x180B50B30", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> BDPBBCLCMMN
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract DPMDGLGHBHJ<T> MMBOOOFMKKG
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5839180", Offset = "0x5837B80", VA = "0x185839180")]
	public MKJJOFDHLJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5838E40", Offset = "0x5837840", VA = "0x185838E40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void BLALHCGAKEF();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class BMPHKDMPHIM<TTask, T> : MKJJOFDHLJK<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class CKNADNPOCLE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public CKNADNPOCLE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x4470B50", Offset = "0x446F550", VA = "0x184470B50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x44710C0", Offset = "0x446FAC0", VA = "0x1844710C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public BMPHKDMPHIM<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public CKNADNPOCLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6A48250", Offset = "0x6A46C50", VA = "0x186A48250")]
		[AsyncStateMachine(typeof(BMPHKDMPHIM<, >.CKNADNPOCLE.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> NCGFBMHMPCH(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> AIPCFMDLKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource LNGJLPHIAOB;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> BDPBBCLCMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override DPMDGLGHBHJ<T> MMBOOOFMKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x65AAEB0", Offset = "0x65A98B0", VA = "0x1865AAEB0")]
	protected BMPHKDMPHIM(TTask AIPCFMDLKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x65AAC90", Offset = "0x65A9690", VA = "0x1865AAC90", Slot = "10")]
	protected override void BLALHCGAKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T DMPOLIDGOED(TTask NMFOLLODJFD);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void IGPGEBAEPBE();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class KJNGHBBOPJI<T> : MKJJOFDHLJK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly GBIBCLBHEOL<Task<T>> CKPGACJICFO;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> BDPBBCLCMMN
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x5071990", Offset = "0x5070390", VA = "0x185071990", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override DPMDGLGHBHJ<T> MMBOOOFMKKG
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x54F8F70", Offset = "0x54F7970", VA = "0x1854F8F70")]
	public KJNGHBBOPJI(GBIBCLBHEOL<Task<T>> IKIJEHJFEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x54F8F50", Offset = "0x54F7950", VA = "0x1854F8F50", Slot = "10")]
	protected override void BLALHCGAKEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class BFLICKKEPEM
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName NAEFKGNNJGO;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> BOHMEOMAEDA;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x82C1EC0", Offset = "0x82C08C0", VA = "0x1882C1EC0")]
	public static int LBDDDCNPKGF(this HEDJGJLFGNJ JCFIEKILDAB, IncrementalHash KEGBPMLIINA, byte[] AOJAGHMCKPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x82C1DD0", Offset = "0x82C07D0", VA = "0x1882C1DD0")]
	public static bool CGOIOLMLCMJ([CanBeNull] this HEDJGJLFGNJ JCFIEKILDAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x82C1780", Offset = "0x82C0180", VA = "0x1882C1780")]
	public static bool CGOIOLMLCMJ([CanBeNull] this HEDJGJLFGNJ JCFIEKILDAB, [Out] string GFHOJCCMEDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x82C1A90", Offset = "0x82C0490", VA = "0x1882C1A90")]
	public static bool CGOIOLMLCMJ([CanBeNull] this HEDJGJLFGNJ JCFIEKILDAB, IncrementalHash KEGBPMLIINA, byte[] AOJAGHMCKPJ, [Out] string GFHOJCCMEDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x82C1E30", Offset = "0x82C0830", VA = "0x1882C1E30")]
	private static bool EBBLIHIPBOL(byte[] EMPDIDLCGDH, Span<byte> GJDJAGBMFIA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class CJNKDNOCJOO
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x82C23A0", Offset = "0x82C0DA0", VA = "0x1882C23A0")]
	public static int KKFNODGLBEO(HashAlgorithmName GFLBFLHJEEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3A6B820", Offset = "0x3A6A220", VA = "0x183A6B820")]
	public static int LBDDDCNPKGF<T>(this T KPJJAPDIIGH, byte[] DMKHAPOFHDM, IncrementalHash KEGBPMLIINA, byte[] OMFNOMOALDJ) where T : PDLFJFGONLE
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface PDLFJFGONLE
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash KEGBPMLIINA);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface HEDJGJLFGNJ : PDLFJFGONLE
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] LNHACFIGMFP
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] FMGNDOAKFID
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class PABOHAALMDJ
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool LNMFKFIDPMD;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> EMNEHIKIHED;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> MAKFDBHDLOB;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding MNGONLIJHDP;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> DAJKCCBIFHL;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3E53EC0", Offset = "0x3E528C0", VA = "0x183E53EC0")]
	public static void JMFMDANEKLF<T>(this IncrementalHash CIKOPJBBOOC, [CanBeNull] T BIMLKJFNDFP) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3E532E0", Offset = "0x3E51CE0", VA = "0x183E532E0")]
	public static void EJOGLBLBABD<T>(this IncrementalHash CIKOPJBBOOC, [CanBeNull] T KPJJAPDIIGH) where T : PDLFJFGONLE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3E539A0", Offset = "0x3E523A0", VA = "0x183E539A0")]
	public static void IBCBHDAIKPF<T>(this IncrementalHash CIKOPJBBOOC, [CanBeNull] IList<T> PGGLDHFDOMK) where T : PDLFJFGONLE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x82C3290", Offset = "0x82C1C90", VA = "0x1882C3290")]
	private static bool DMKBOEMHDGA([CanBeNull] PDLFJFGONLE KPJJAPDIIGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x82C3380", Offset = "0x82C1D80", VA = "0x1882C3380")]
	public static void FOIHHJOBAPC(this IncrementalHash KEGBPMLIINA, string? JKGLGLIKHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x82C3B90", Offset = "0x82C2590", VA = "0x1882C3B90")]
	public static void LMCIKJDKGCA(this IncrementalHash KEGBPMLIINA, long NJAAONPMDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x82C37F0", Offset = "0x82C21F0", VA = "0x1882C37F0")]
	public static void HBKKGFAHLHC(this IncrementalHash KEGBPMLIINA, int KFGAPPFNMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x82C3D60", Offset = "0x82C2760", VA = "0x1882C3D60")]
	public static void OAANHLBCMHA(this IncrementalHash KEGBPMLIINA, short KMABMAAPKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x82C2FF0", Offset = "0x82C19F0", VA = "0x1882C2FF0")]
	public static void AJJMKJHPFOG(this IncrementalHash KEGBPMLIINA, byte KHFOLFADBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x82C3A20", Offset = "0x82C2420", VA = "0x1882C3A20")]
	public static void KJDKEPJJFFE(this IncrementalHash KEGBPMLIINA, bool DAEPDMPPNAP, bool CGDDLDBJBME = false, bool ONBMDPMKCKD = false, bool MGIJFJGNIBN = false, bool CNAGLOOOKOA = false, bool DPKPDCMFPPP = false, bool DKNADOFBBBK = false, bool DGBNJBEFBIH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3E53370", Offset = "0x3E51D70", VA = "0x183E53370")]
	public static void GFAGKKHDLKF<T>(this IncrementalHash KEGBPMLIINA, T IGABBOEDEPP) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x82C39C0", Offset = "0x82C23C0", VA = "0x1882C39C0")]
	public static void HCENPPPKPKG(this IncrementalHash KEGBPMLIINA, float JGDJHBMKBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x82C3790", Offset = "0x82C2190", VA = "0x1882C3790")]
	public static void GJLDJAIIADH(this IncrementalHash KEGBPMLIINA, ulong IHKONMOMFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x82C3100", Offset = "0x82C1B00", VA = "0x1882C3100")]
	public static void CHAPBNHJEGO(this IncrementalHash KEGBPMLIINA, uint AJJEEKPBJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x82C3320", Offset = "0x82C1D20", VA = "0x1882C3320")]
	public static void EPGAOJBPFIB(this IncrementalHash KEGBPMLIINA, ushort IBNFLCJHGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x82C3160", Offset = "0x82C1B60", VA = "0x1882C3160")]
	public static void DBAAKIMIGHD(this IncrementalHash KEGBPMLIINA, Vector3 BBCLOPMLAGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class PJIBFBEHMDN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x82C41D0", Offset = "0x82C2BD0", VA = "0x1882C41D0")]
	public PJIBFBEHMDN(string ONGDPODJNBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class HIPNKJIFOEI
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void BOCPNCHFCBL(ushort NPDBMNKGJFH, ushort AAPKGPJNJHL, ushort PIDGIMKFOGJ, ushort NIBJILJBNHA);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void PKHCMDPDBKC(ushort PNKAKCCNKBM, ushort CBHJGPJPFPJ);

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate void CIHPOOBILMP();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort DJFLLDBNBEE = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	protected HIPNKJIFOEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class NPBHOFHGFAO<T> : HIPNKJIFOEI where T : NPBHOFHGFAO<T>.NHJLHHHCCHO
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public interface NHJLHHHCCHO
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		PKHCMDPDBKC LHFFNEOLKGA
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		PKHCMDPDBKC GDEDAHFBDHD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		CIHPOOBILMP FKFAOCBJEFD
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> PCJIJEDHJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private CIHPOOBILMP OPLLBENFHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private CIHPOOBILMP DKIENLONCKO;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool ELACJKGOIND
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xAD3450", Offset = "0xAD1E50", VA = "0x180AD3450")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA87B30", Offset = "0xA86530", VA = "0x180A87B30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort BGBKLAEJDBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x12585E0", Offset = "0x1256FE0", VA = "0x1812585E0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x12585F0", Offset = "0x1256FF0", VA = "0x1812585F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort POLMLEGONGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x58F0330", Offset = "0x58EED30", VA = "0x1858F0330")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x58F0260", Offset = "0x58EEC60", VA = "0x1858F0260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort MKNGHDHFHHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xF326E0", Offset = "0xF310E0", VA = "0x180F326E0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xF327A0", Offset = "0xF311A0", VA = "0x180F327A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort FPLPIEIBKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x58F0310", Offset = "0x58EED10", VA = "0x1858F0310")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x58F0320", Offset = "0x58EED20", VA = "0x1858F0320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool HELACPOEMBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1258460", Offset = "0x1256E60", VA = "0x181258460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool LGGENLDABPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x103E1D0", Offset = "0x103CBD0", VA = "0x18103E1D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event BOCPNCHFCBL FNIFIKLNFOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x58F0270", Offset = "0x58EEC70", VA = "0x1858F0270")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x58EF690", Offset = "0x58EE090", VA = "0x1858EF690")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x58F0370", Offset = "0x58EED70", VA = "0x1858F0370")]
	private T PNLIFJPENAG(ushort LOHDKHIFIGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x58EF7A0", Offset = "0x58EE1A0", VA = "0x1858EF7A0")]
	private T GDNNCGIGHHI(ushort LOHDKHIFIGO, ushort IJEOIALFIEE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x58EF840", Offset = "0x58EE240", VA = "0x1858EF840")]
	protected T IJNFNCHBKPM(uint KDOBNLMKGPK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x58F0400", Offset = "0x58EEE00", VA = "0x1858F0400")]
	protected NPBHOFHGFAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x58EF670", Offset = "0x58EE070", VA = "0x1858EF670")]
	public void CMGCEILHAJG(ushort FHMGDDFLCGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x58EF550", Offset = "0x58EDF50", VA = "0x1858EF550")]
	public void CMGCEILHAJG(ushort FHMGDDFLCGH, ushort BOCECGBLNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x58EF5A0", Offset = "0x58EDFA0", VA = "0x1858EF5A0", Slot = "4")]
	protected virtual void CMGCEILHAJG(uint JGGALKHFHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x58EFAE0", Offset = "0x58EE4E0", VA = "0x1858EFAE0")]
	protected void JLELDMLCJAD(uint JGGALKHFHMN, uint CBCGJPOPCNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x58EF730", Offset = "0x58EE130", VA = "0x1858EF730")]
	protected void FJFGHBFNJFM(ushort LOHDKHIFIGO, ushort IJEOIALFIEE, T BLKFHFCBEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x58F0340", Offset = "0x58EED40", VA = "0x1858F0340")]
	private void PIELMNGBGAC(uint KDOBNLMKGPK, T BLKFHFCBEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x58EF890", Offset = "0x58EE290", VA = "0x1858EF890")]
	protected void IJNLBCOLNNI(float NIHEEOMEEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x58EF540", Offset = "0x58EDF40", VA = "0x1858EF540")]
	protected uint BMNEFNLFPNJ(ushort LOHDKHIFIGO, ushort IJEOIALFIEE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x58EF530", Offset = "0x58EDF30", VA = "0x1858EF530")]
	protected ushort ALLJKEODJEG(uint JHMCFILKLKJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x58EF830", Offset = "0x58EE230", VA = "0x1858EF830")]
	protected ushort IANPALAFOAM(uint JHMCFILKLKJ)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class AJPHJHBJKOD : NPBHOFHGFAO<AJPHJHBJKOD.KMFMPDDIHME>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class KMFMPDDIHME : NHJLHHHCCHO
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public PKHCMDPDBKC LHFFNEOLKGA
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public PKHCMDPDBKC GDEDAHFBDHD
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public CIHPOOBILMP FKFAOCBJEFD
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KMFMPDDIHME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x82C1510", Offset = "0x82BFF10", VA = "0x1882C1510")]
	public void KIGNIGHMHHA(ushort MIBHPAFPEMO, PKHCMDPDBKC GPMJCHPOEAC, PKHCMDPDBKC NJFHCDOFKHN, CIHPOOBILMP EMNJMFBCMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x82C15F0", Offset = "0x82BFFF0", VA = "0x1882C15F0")]
	public void KIGNIGHMHHA(ushort LOHDKHIFIGO, ushort IJEOIALFIEE, PKHCMDPDBKC GPMJCHPOEAC, PKHCMDPDBKC NJFHCDOFKHN, CIHPOOBILMP EMNJMFBCMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x82C14C0", Offset = "0x82BFEC0", VA = "0x1882C14C0")]
	public void AIICKBIOPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x82C16D0", Offset = "0x82C00D0", VA = "0x1882C16D0")]
	protected AJPHJHBJKOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class OBGDMMLHNGI : AJPHJHBJKOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool ABCPPNJCCKJ;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool GHGHOCPHKLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xD49720", Offset = "0xD48120", VA = "0x180D49720")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xE571D0", Offset = "0xE55BD0", VA = "0x180E571D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x82C2F30", Offset = "0x82C1930", VA = "0x1882C2F30")]
	public void ICNIAFDKEKI(ushort IDNIHAMDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x82C2F90", Offset = "0x82C1990", VA = "0x1882C2F90")]
	public void ICNIAFDKEKI(ushort IDNIHAMDNKO, ushort IJBHDDNGKNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x82C16D0", Offset = "0x82C00D0", VA = "0x1882C16D0")]
	public OBGDMMLHNGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class NCDDEEILOPE<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal class IBNPJAJDPOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode NLDLHIJAJBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode DFKFFPKHNCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public CDIEJHFOBON ICBGFNPAHKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<CDIEJHFOBON> GMAKGKJLBJO;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public IBNPJAJDPOL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal struct CDIEJHFOBON : IComparable<CDIEJHFOBON>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int BMCIDDEOPIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant AHENMAAIDKH;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x1900540", Offset = "0x18FEF40", VA = "0x181900540")]
		public CDIEJHFOBON(int BMCIDDEOPIC, TClaimant AHENMAAIDKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x696AED0", Offset = "0x69698D0", VA = "0x18696AED0")]
		public bool LKBIPLHNOLP([In] CDIEJHFOBON EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x696AEC0", Offset = "0x69698C0", VA = "0x18696AEC0")]
		public bool KAEPOJOJNGK([In] CDIEJHFOBON EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x696AEB0", Offset = "0x69698B0", VA = "0x18696AEB0", Slot = "4")]
		public int CompareTo(CDIEJHFOBON EFNHKCDKOGH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x696AF30", Offset = "0x6969930", VA = "0x18696AF30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum BFGKCJJFGCE
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class OPJOIDAGALF : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public NCDDEEILOPE<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xFEC320", Offset = "0xFEAD20", VA = "0x180FEC320")]
		[DebuggerHidden]
		public OPJOIDAGALF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5A37BA0", Offset = "0x5A365A0", VA = "0x185A37BA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x5A37D60", Offset = "0x5A36760", VA = "0x185A37D60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x5A37C80", Offset = "0x5A36680", VA = "0x185A37C80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x4E9D4C0", Offset = "0x4E9BEC0", VA = "0x184E9D4C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly GAJJEGFOAHO<IBNPJAJDPOL> LIHBGHKLAKA;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly GAJJEGFOAHO<List<CDIEJHFOBON>> MBLNDKLDMOM;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int HKIPHPAOJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> GPKIGFJHEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, IBNPJAJDPOL> JAJANKEDIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private BFGKCJJFGCE JFFMBFIHKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool JAFNIEKLOJN;

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode OOPAOLMCLLD(TNode AAPGFEFGBOK);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void IIAJLNBNEFM(TNode AAPGFEFGBOK, TClaimant FNPOLODDLAF, TClaimant LHPBEGHPIMF);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x58A65F0", Offset = "0x58A4FF0", VA = "0x1858A65F0")]
	public NCDDEEILOPE(BFGKCJJFGCE JFFMBFIHKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x58A57A0", Offset = "0x58A41A0", VA = "0x1858A57A0")]
	public void GAALNEAIAGE(TNode AAPGFEFGBOK, TNode OGINNIAMBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x58A5D00", Offset = "0x58A4700", VA = "0x1858A5D00")]
	public void NOGIGJHKKHO(TClaimant AHENMAAIDKH, TNode LJIKOHNJFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x58A5270", Offset = "0x58A3C70", VA = "0x1858A5270", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x58A58A0", Offset = "0x58A42A0", VA = "0x1858A58A0")]
	private void MHNMEMHKOFG(TClaimant AHENMAAIDKH, TNode AFCHAAFEHAN, TNode LJIKOHNJFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x58A5830", Offset = "0x58A4230", VA = "0x1858A5830")]
	private int MAMPJEDMJDB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x58A4DB0", Offset = "0x58A37B0", VA = "0x1858A4DB0")]
	private void DCFFJPEEMFE(TClaimant AHENMAAIDKH, TNode FLDLEKDOJDD, TNode MPDPLFNEIAK, int NLGLLGNEMIK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x58A51E0", Offset = "0x58A3BE0", VA = "0x1858A51E0")]
	private void DNBBFDGDBBK(CDIEJHFOBON GKIJFCIPAAF, IBNPJAJDPOL BFDHJGKAFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x58A6040", Offset = "0x58A4A40", VA = "0x1858A6040")]
	private void PHOHBIEPLIA(TClaimant AHENMAAIDKH, TNode FLDLEKDOJDD, TNode MPDPLFNEIAK, int NLGLLGNEMIK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x58A6320", Offset = "0x58A4D20", VA = "0x1858A6320")]
	private void POALKKBEIMF(CDIEJHFOBON GKIJFCIPAAF, TNode AAPGFEFGBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x58A50F0", Offset = "0x58A3AF0", VA = "0x1858A50F0")]
	private void DJPMCAAELAF(CDIEJHFOBON GKIJFCIPAAF, IBNPJAJDPOL BFDHJGKAFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x58A5E20", Offset = "0x58A4820", VA = "0x1858A5E20")]
	private void OAOAKHPLAGG(IBNPJAJDPOL BFDHJGKAFLJ, bool OBHPFHLGPFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x58A5440", Offset = "0x58A3E40", VA = "0x1858A5440")]
	private void FOAGIMMMGPJ(IBNPJAJDPOL BFDHJGKAFLJ, TNode OGINNIAMBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x58A5C20", Offset = "0x58A4620", VA = "0x1858A5C20")]
	[IteratorStateMachine(typeof(NCDDEEILOPE<, >.OPJOIDAGALF))]
	private IEnumerable<TNode> NLKHNOKDHJO(TNode FLDLEKDOJDD, TNode MPDPLFNEIAK, bool JCDCHGJEFKH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x58A5F50", Offset = "0x58A4950", VA = "0x1858A5F50")]
	private IBNPJAJDPOL OMIPHNDJCGM(TNode AAPGFEFGBOK, TNode DFKFFPKHNCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x58A5AB0", Offset = "0x58A44B0", VA = "0x1858A5AB0")]
	private IBNPJAJDPOL MPDOPJLEKCF(TNode AAPGFEFGBOK, TNode DFKFFPKHNCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x58A5940", Offset = "0x58A4340", VA = "0x1858A5940")]
	private void MMNEMJJKEHG(IBNPJAJDPOL BFDHJGKAFLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class AFFEEHDLACO<T> : IEnumerable<AFFEEHDLACO<T>.AMBOAOFLBPN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public struct AMBOAOFLBPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T PDKJBMPOMNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int FILGHJLFKAL;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class BJEADMIPFGH : IEnumerator<AMBOAOFLBPN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private AFFEEHDLACO<T> EKGECJENMCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int FILGHJLFKAL;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x4987B40", Offset = "0x4986540", VA = "0x184987B40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public AMBOAOFLBPN CEKGODBONJL
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x65A0240", Offset = "0x659EC40", VA = "0x1865A0240", Slot = "4")]
			get
			{
				return default(AMBOAOFLBPN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x65A0150", Offset = "0x659EB50", VA = "0x1865A0150")]
		public BJEADMIPFGH(AFFEEHDLACO<T> EKGECJENMCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x65A00D0", Offset = "0x659EAD0", VA = "0x1865A00D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x49EEC70", Offset = "0x49ED670", VA = "0x1849EEC70", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x12E6830", Offset = "0x12E5230", VA = "0x1812E6830", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private struct DMBMILAHOHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool ALOOOOLNNGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T PDKJBMPOMNC;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int NIGMHJACJHP = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> OPNKMAPOEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private DMBMILAHOHN[] LMBCAJFBBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int OECENDEDHGB;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int MGPAMDGHIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xC33060", Offset = "0xC31A60", VA = "0x180C33060")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x1058A60", Offset = "0x1057460", VA = "0x181058A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x4488F50", Offset = "0x4487950", VA = "0x184488F50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x52378A0", Offset = "0x52362A0", VA = "0x1852378A0")]
	public AFFEEHDLACO(int MOCOCCPAPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5237980", Offset = "0x5236380", VA = "0x185237980")]
	public AFFEEHDLACO(AMBOAOFLBPN[] OHJJFPFKDML, bool KAPACCPNGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x5236810", Offset = "0x5235210", VA = "0x185236810")]
	public int JOMJECAKHJE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x52368A0", Offset = "0x52352A0", VA = "0x1852368A0")]
	private int KFPOOHFPFPM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x5237320", Offset = "0x5235D20", VA = "0x185237320", Slot = "6")]
	protected virtual uint OBMJBLCABJM(uint KEGBPMLIINA, T PDKJBMPOMNC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x5236D00", Offset = "0x5235700", VA = "0x185236D00")]
	public bool KGHAKBLMNFC(T PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5237380", Offset = "0x5235D80", VA = "0x185237380")]
	public int PHAFKMIFCNM(T PDKJBMPOMNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x5236D50", Offset = "0x5235750", VA = "0x185236D50")]
	public T LAFPCILEMFP(int FILGHJLFKAL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5236E10", Offset = "0x5235810", VA = "0x185236E10")]
	public bool NKALLCACMDG(T PDKJBMPOMNC, bool KNHNEBPEJIO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5236E60", Offset = "0x5235860", VA = "0x185236E60")]
	public bool NKALLCACMDG(T PDKJBMPOMNC, int FILGHJLFKAL, bool KNHNEBPEJIO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5236770", Offset = "0x5235170", VA = "0x185236770")]
	private int BELDEFFLIMM(int EMMDOKDGNJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x5237450", Offset = "0x5235E50", VA = "0x185237450", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x5237450", Offset = "0x5235E50", VA = "0x185237450", Slot = "4")]
	private IEnumerator<AMBOAOFLBPN> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class GAJJEGFOAHO<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> FOHPIGBHJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> CGMCBGOHFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int OOGABFHLJPJ;

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0B00", Offset = "0x4ECF500", VA = "0x184ED0B00")]
	public static GAJJEGFOAHO<T> ALHAMLENCLF(int MOCOCCPAPIH = 0, int OOGABFHLJPJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0BE0", Offset = "0x4ECF5E0", VA = "0x184ED0BE0")]
	public static GAJJEGFOAHO<T> CILJHOBAHGB(int MOCOCCPAPIH = 0, int OOGABFHLJPJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x4ED1400", Offset = "0x4ECFE00", VA = "0x184ED1400")]
	public GAJJEGFOAHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x4ED1430", Offset = "0x4ECFE30", VA = "0x184ED1430")]
	public GAJJEGFOAHO(int MOCOCCPAPIH, int OOGABFHLJPJ = int.MaxValue, bool CAEDLODKFKD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x4ED1240", Offset = "0x4ECFC40", VA = "0x184ED1240")]
	public T PKPFHCOKDBD()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x4ED1160", Offset = "0x4ECFB60", VA = "0x184ED1160")]
	public void OEENGNANBPH(T PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0E10", Offset = "0x4ECF810", VA = "0x184ED0E10")]
	private void FIDMBNPOBHN(T PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x4ED13E0", Offset = "0x4ECFDE0", VA = "0x184ED13E0")]
	private void PPDOMCAELNB(T PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0CC0", Offset = "0x4ECF6C0", VA = "0x184ED0CC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0EF0", Offset = "0x4ECF8F0", VA = "0x184ED0EF0")]
	private void IIPPLAMLKBP(IEnumerable<T> EJKNLPOFFNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class EKDPPDICLOD<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> JAGEKIFCALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T NMNGPBNPOFE;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T HFALJLBIPNP
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x49427B0", Offset = "0x49411B0", VA = "0x1849427B0")]
	public bool AOFFLNBKOEM(T PDKJBMPOMNC, int BMCIDDEOPIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x4917050", Offset = "0x4915A50", VA = "0x184917050")]
	public bool DMGCHJPPPFG(int BMCIDDEOPIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x4942C30", Offset = "0x4941630", VA = "0x184942C30")]
	public T LBKBFEOMCAC(int HPKIKDHCJDL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x49428E0", Offset = "0x49412E0", VA = "0x1849428E0")]
	private bool KCLHBDMGPPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x4942E30", Offset = "0x4941830", VA = "0x184942E30")]
	public bool PKNEHCKDABA(int BMCIDDEOPIC, [Out] T PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x4942E80", Offset = "0x4941880", VA = "0x184942E80")]
	public EKDPPDICLOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class EBDKOPBLPFO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	protected struct MHLKHPDJAJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T BHKLFFIKDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int MCOLDCCMNAM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<MHLKHPDJAJO> MMJBIBLKAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T AHPGLDJCEHL;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x4488F50", Offset = "0x4487950", VA = "0x184488F50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4915920", Offset = "0x4914320", VA = "0x184915920")]
	public bool JBFDGOBACLK(T PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4915D00", Offset = "0x4914700", VA = "0x184915D00")]
	public void MJGPLOFFIKO(T PDKJBMPOMNC, int BMCIDDEOPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4915490", Offset = "0x4913E90", VA = "0x184915490")]
	public bool BBOPECIHIDA(T PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x49157A0", Offset = "0x49141A0", VA = "0x1849157A0")]
	public void CHLOADNGFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4915880", Offset = "0x4914280", VA = "0x184915880")]
	public T CNBFFOCFFDL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x4915E20", Offset = "0x4914820", VA = "0x184915E20")]
	protected void PPLIEBMDEFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x4916130", Offset = "0x4914B30", VA = "0x184916130")]
	public EBDKOPBLPFO()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[OICBHOIKJDP(MGLGMLBODOF.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x82C4460", Offset = "0x82C2E60", VA = "0x1882C4460")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x82C4730", Offset = "0x82C3130", VA = "0x1882C4730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x82C4640", Offset = "0x82C3040", VA = "0x1882C4640")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x82C43B0", Offset = "0x82C2DB0", VA = "0x1882C43B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x82C4680", Offset = "0x82C3080", VA = "0x1882C4680")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x82C4590", Offset = "0x82C2F90", VA = "0x1882C4590")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x82C4320", Offset = "0x82C2D20", VA = "0x1882C4320")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x5D3E560", Offset = "0x5D3CF60", VA = "0x185D3E560", Slot = "4")]
		public virtual T GPAEGPGMCNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface DCKGCPOEEHO
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	ToolHierarchyCache BFCPLFOHIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public struct ONIDEGMGMGH<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private readonly List<Component> CKDFPBCCFHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private readonly bool DDPNKGPGBLK;

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x1A64500", Offset = "0x1A62F00", VA = "0x181A64500")]
			public ONIDEGMGMGH(List<Component> CKDFPBCCFHO, bool DDPNKGPGBLK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x5A2AFE0", Offset = "0x5A299E0", VA = "0x185A2AFE0")]
			public OLNFGNJNPMC<T> IBBMHAHFLHH()
			{
				return default(OLNFGNJNPMC<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x5A2B040", Offset = "0x5A29A40", VA = "0x185A2B040", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x5A2B040", Offset = "0x5A29A40", VA = "0x185A2B040", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public struct OLNFGNJNPMC<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly List<Component> CKDFPBCCFHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private readonly bool DDPNKGPGBLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private int FILGHJLFKAL;

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public T CEKGODBONJL
			{
				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x5A29010", Offset = "0x5A27A10", VA = "0x185A29010", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x5A28FA0", Offset = "0x5A279A0", VA = "0x185A28FA0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x5A28FE0", Offset = "0x5A279E0", VA = "0x185A28FE0")]
			public OLNFGNJNPMC(List<Component> CKDFPBCCFHO, bool DDPNKGPGBLK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x5A28EE0", Offset = "0x5A278E0", VA = "0x185A28EE0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x5A28EF0", Offset = "0x5A278F0", VA = "0x185A28EF0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x49DC130", Offset = "0x49DAB30", VA = "0x1849DC130", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x82C6190", Offset = "0x82C4B90", VA = "0x1882C6190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x82C5F00", Offset = "0x82C4900", VA = "0x1882C5F00")]
		private void ICNIAFDKEKI(GameObject EJLPJBJLNAK, bool FGLPKBNAEFO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x82C6070", Offset = "0x82C4A70", VA = "0x1882C6070")]
		public static void ICNIAFDKEKI(GameObject EJLPJBJLNAK, ToolHierarchyCache FNLAOKPMGLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x82C5E00", Offset = "0x82C4800", VA = "0x1882C5E00")]
		public void ECGDFBBCFAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x404C230", Offset = "0x404AC30", VA = "0x18404C230")]
		public void EKEICHGMGOB<T>(Action<T> FOAIPBIEILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x404C450", Offset = "0x404AE50", VA = "0x18404C450")]
		public T OFKCBIMHCDO<T>(bool DDPNKGPGBLK = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x404C170", Offset = "0x404AB70", VA = "0x18404C170")]
		public ONIDEGMGMGH<T> EFBGKGGELLJ<T>(bool DDPNKGPGBLK = false) where T : class
		{
			return default(ONIDEGMGMGH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x82C5A70", Offset = "0x82C4470", VA = "0x1882C5A70")]
		public List<Component> CIDJKJBOALC(Type AEOGKDPPBBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x82C5E10", Offset = "0x82C4810", VA = "0x1882C5E10", Slot = "4")]
		public bool Equals(ToolHierarchyCache IECENJOJFJH, ToolHierarchyCache OFOCBNJJIJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x82C5E90", Offset = "0x82C4890", VA = "0x1882C5E90", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache CEFJEHJNIAP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class MGMILBBCLGH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private int MOCOCCPAPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int IHOBFHHPIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<T> DFFANDBINOB;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5071990", Offset = "0x5070390", VA = "0x185071990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public T EILPADPNPDF
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x5824C70", Offset = "0x5823670", VA = "0x185824C70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public T MFCKIOKPFMN
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x5824AD0", Offset = "0x58234D0", VA = "0x185824AD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public T IGNEEIHOBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x5825110", Offset = "0x5823B10", VA = "0x185825110")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x58251A0", Offset = "0x5823BA0", VA = "0x1858251A0")]
	public MGMILBBCLGH(int MOCOCCPAPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x5824ED0", Offset = "0x58238D0", VA = "0x185824ED0")]
	public void MJGPLOFFIKO(T KDGNOADNGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x5824A30", Offset = "0x5823430", VA = "0x185824A30")]
	public void CHLOADNGFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x5824FE0", Offset = "0x58239E0", VA = "0x185824FE0")]
	public void NFDOHFBOIGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x5824A70", Offset = "0x5823470", VA = "0x185824A70")]
	public void EJJJMFNCOMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5824DD0", Offset = "0x58237D0", VA = "0x185824DD0")]
	public void MJEDDCFGBDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x5824D50", Offset = "0x5823750", VA = "0x185824D50")]
	public List<T> IDOCMMAOLAM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class LIMEFMJFLAN<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct JKLMABKDPLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int MCOLDCCMNAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public T BHKLFFIKDPE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Dictionary<object, JKLMABKDPLA> JAGEKIFCALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly EqualityComparer<T> JFGJGBKBJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private T NMNGPBNPOFE;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public virtual T HFALJLBIPNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xE7AD80", Offset = "0xE79780", VA = "0x180E7AD80", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x5612530", Offset = "0x5610F30", VA = "0x185612530", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool HGKJCJCLKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x5615060", Offset = "0x5613A60", VA = "0x185615060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public object CPPGHJGCJHO
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5611FC0", Offset = "0x56109C0", VA = "0x185611FC0")]
	public bool AOFFLNBKOEM(T PDKJBMPOMNC, object DHNMCOFINFM, int BMCIDDEOPIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x5612480", Offset = "0x5610E80", VA = "0x185612480")]
	public bool DMGCHJPPPFG(object DHNMCOFINFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x5615480", Offset = "0x5613E80", VA = "0x185615480")]
	public bool PKNEHCKDABA(object DHNMCOFINFM, [Out] T PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x5612450", Offset = "0x5610E50", VA = "0x185612450")]
	public void CHLOADNGFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x56125B0", Offset = "0x5610FB0", VA = "0x1856125B0")]
	private bool KCLHBDMGPPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x56158D0", Offset = "0x56142D0", VA = "0x1856158D0")]
	public LIMEFMJFLAN()
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
