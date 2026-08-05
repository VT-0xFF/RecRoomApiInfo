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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C1B7B0", Offset = "0x7C1A9B0", VA = "0x187C1B7B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA2C560", Offset = "0xA2B760", VA = "0x180A2C560")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2C5A0", Offset = "0xA2B7A0", VA = "0x180A2C5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IOCKBOIOCOF : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2189610", Offset = "0x2188810", VA = "0x182189610")]
	public IOCKBOIOCOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, KMNLAPLHDFO, LPPLGHAJPJI, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA00F60", Offset = "0xA00160", VA = "0x180A00F60", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA01190", Offset = "0xA00390", VA = "0x180A01190", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash BNPHOCLLMDF);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xC19EC0", Offset = "0xC190C0", VA = "0x180C19EC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C1CCC0", Offset = "0x7C1BEC0", VA = "0x187C1CCC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C1CC80", Offset = "0x7C1BE80", VA = "0x187C1CC80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C1CD00", Offset = "0x7C1BF00", VA = "0x187C1CD00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C1CEB0", Offset = "0x7C1C0B0", VA = "0x187C1CEB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7C1CE20", Offset = "0x7C1C020", VA = "0x187C1CE20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1104F70", Offset = "0x1104170", VA = "0x181104F70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xDAC160", Offset = "0xDAB360", VA = "0x180DAC160")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C1CC40", Offset = "0x7C1BE40", VA = "0x187C1CC40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C1CD90", Offset = "0x7C1BF90", VA = "0x187C1CD90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C6E0", Offset = "0x7C1B8E0", VA = "0x187C1C6E0")]
	public void CopyBounds(SavedExtents CMOCFNBHPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CB90", Offset = "0x7C1BD90", VA = "0x187C1CB90")]
	public void SetLocalSpaceBounds(Bounds DDEEEAIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1525BC0", Offset = "0x1524DC0", VA = "0x181525BC0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CB80", Offset = "0x7C1BD80", VA = "0x187C1CB80")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C7D0", Offset = "0x7C1B9D0", VA = "0x187C1C7D0")]
	private void HLJPIPCHOCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C980", Offset = "0x7C1BB80", VA = "0x187C1C980")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C0A0", Offset = "0x7C1B2A0", VA = "0x187C1C0A0")]
	public static void CalculateLocalBoundsFor(GameObject LBBGHAOMHLO, [Out] Bounds DDEEEAIJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C710", Offset = "0x7C1B910", VA = "0x187C1C710")]
	private static void GBBPBCICKEJ(Bounds NIJBGCGEGBN, Color NAGHCPKAEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CBB0", Offset = "0x7C1BDB0", VA = "0x187C1CBB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA00110", Offset = "0x9FF310", VA = "0x180A00110")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA03700", Offset = "0xA02900", VA = "0x180A03700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x19DE5B0", Offset = "0x19DD7B0", VA = "0x1819DE5B0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5900A20", Offset = "0x58FFC20", VA = "0x185900A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "4")]
	public virtual void NLGMPHHLNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
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
	[IOCKBOIOCOF]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5900650", Offset = "0x58FF850", VA = "0x185900650", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x58FF4A0", Offset = "0x58FE6A0", VA = "0x1858FF4A0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5900980", Offset = "0x58FFB80", VA = "0x185900980")]
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
	private sealed class CKMFJNBOIME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public CKMFJNBOIME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x67D0890", Offset = "0x67CFA90", VA = "0x1867D0890")]
		internal int PKLJPGFJCDM(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[IOCKBOIOCOF]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x46F4D50", Offset = "0x46F3F50", VA = "0x1846F4D50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x46F4D90", Offset = "0x46F3F90", VA = "0x1846F4D90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x46F4C70", Offset = "0x46F3E70", VA = "0x1846F4C70", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey MHDODBCCAJB]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x46F4CF0", Offset = "0x46F3EF0", VA = "0x1846F4CF0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x46F4B70", Offset = "0x46F3D70", VA = "0x1846F4B70", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x46F4890", Offset = "0x46F3A90", VA = "0x1846F4890", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x46F3D80", Offset = "0x46F2F80", VA = "0x1846F3D80", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x46F3D50", Offset = "0x46F2F50", VA = "0x1846F3D50", Slot = "14")]
	protected virtual string OLKPDNNKMAG(TKeyVal MEENFPJJIBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x46F3C10", Offset = "0x46F2E10", VA = "0x1846F3C10", Slot = "4")]
	public bool ContainsKey(TKey MHDODBCCAJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x46F4A40", Offset = "0x46F3C40", VA = "0x1846F4A40", Slot = "5")]
	public bool TryGetValue(TKey MHDODBCCAJB, [Out] TVal KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x46F3C50", Offset = "0x46F2E50", VA = "0x1846F3C50", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x46F3C50", Offset = "0x46F2E50", VA = "0x1846F3C50", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x46F4A80", Offset = "0x46F3C80", VA = "0x1846F4A80")]
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
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA00FA0", Offset = "0xA001A0", VA = "0x180A00FA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA00F60", Offset = "0xA00160", VA = "0x180A00F60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
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
		[Cpp2IlInjected.Address(RVA = "0x462DEB0", Offset = "0x462D0B0", VA = "0x18462DEB0")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[IOCKBOIOCOF]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x59020E0", Offset = "0x59012E0", VA = "0x1859020E0")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5901A30", Offset = "0x5900C30", VA = "0x185901A30", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x59010B0", Offset = "0x59002B0", VA = "0x1859010B0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class DFFMKKJFEGH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct ABDABNFCNLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T LFLEGEJLLKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float LOCNBAEFIGA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int KBCHAIKMDLE = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float JEKHPHJGOFO = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly ABDABNFCNLO[] KBILCKNPAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int LAIMHEBNDNH;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float KLPJFEBNMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xC79E20", Offset = "0xC79020", VA = "0x180C79E20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xCB9A30", Offset = "0xCB8C30", VA = "0x180CB9A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T JPJIDOHIEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA00F60", Offset = "0xA00160", VA = "0x180A00F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x420C830", Offset = "0x420BA30", VA = "0x18420C830")]
	protected DFFMKKJFEGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x420C850", Offset = "0x420BA50", VA = "0x18420C850")]
	protected DFFMKKJFEGH(int GCFCAGDGDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x420C5B0", Offset = "0x420B7B0", VA = "0x18420C5B0")]
	public void LHOMNBOIMGH(float MGFEHNJFHAM, T KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool EKMHKMKLFMN(float DNCFBNJKCBM, float HDGDLGPCNBD, [Out] T KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool NLGAAMKMOOA(float DNCFBNJKCBM, float HDGDLGPCNBD, [Out] T KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x420C770", Offset = "0x420B970", VA = "0x18420C770")]
	public void OLKFAGPLGGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PGJOBDFNIJH : DFFMKKJFEGH<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B890", Offset = "0x7C1AA90", VA = "0x187C1B890", Slot = "4")]
	public override bool EKMHKMKLFMN(float DNCFBNJKCBM, float HDGDLGPCNBD, [Out] Vector3 KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B9F0", Offset = "0x7C1ABF0", VA = "0x187C1B9F0", Slot = "5")]
	public override bool NLGAAMKMOOA(float DNCFBNJKCBM, float HDGDLGPCNBD, [Out] Vector3 KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7C1BB30", Offset = "0x7C1AD30", VA = "0x187C1BB30")]
	public PGJOBDFNIJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class PHECMJGJNLH
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3BC60B0", Offset = "0x3BC52B0", VA = "0x183BC60B0")]
	public static BGJLKFNGLAO<T1, T2> DBJJOAFKEPP<T1, T2>(T1 LDEOKNOAGOL, T2 HODMKGCOICC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3BC6130", Offset = "0x3BC5330", VA = "0x183BC6130")]
	public static CJCHICPNDPO<T1, T2, T3> DBJJOAFKEPP<T1, T2, T3>(T1 LDEOKNOAGOL, T2 HODMKGCOICC, T3 DOFMMAHEGNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x545F870", Offset = "0x545EA70", VA = "0x18545F870")]
	internal static int ADBMLFPJBJC(int IIAIDLPKCIM, int OPGNEKFNLOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6DF24C0", Offset = "0x6DF16C0", VA = "0x186DF24C0")]
	internal static int ADBMLFPJBJC(int IIAIDLPKCIM, int OPGNEKFNLOL, int HIFBMDHIJHP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BGJLKFNGLAO<T1, T2> : IComparable<BGJLKFNGLAO<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 AGGOAMCNJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 OPJAFOBGHIP;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6195BE0", Offset = "0x6194DE0", VA = "0x186195BE0")]
	public BGJLKFNGLAO(T1 LDEOKNOAGOL, T2 HODMKGCOICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6194340", Offset = "0x6193540", VA = "0x186194340", Slot = "4")]
	public int CompareTo(BGJLKFNGLAO<T1, T2> CMOCFNBHPLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6194A50", Offset = "0x6193C50", VA = "0x186194A50", Slot = "0")]
	public override bool Equals(object CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x61950A0", Offset = "0x61942A0", VA = "0x1861950A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6195370", Offset = "0x6194570", VA = "0x186195370", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CJCHICPNDPO<T1, T2, T3> : IComparable<CJCHICPNDPO<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 AGGOAMCNJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 OPJAFOBGHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 CNPCLBNICOA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x67CC270", Offset = "0x67CB470", VA = "0x1867CC270")]
	public CJCHICPNDPO(T1 LDEOKNOAGOL, T2 HODMKGCOICC, T3 DOFMMAHEGNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x67CB950", Offset = "0x67CAB50", VA = "0x1867CB950", Slot = "4")]
	public int CompareTo(CJCHICPNDPO<T1, T2, T3> CMOCFNBHPLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x67CBBB0", Offset = "0x67CADB0", VA = "0x1867CBBB0", Slot = "0")]
	public override bool Equals(object CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x67CBE80", Offset = "0x67CB080", VA = "0x1867CBE80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x67CC0C0", Offset = "0x67CB2C0", VA = "0x1867CC0C0", Slot = "3")]
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
	public AnimationCurve FNKKGCHNMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T JDDAPAFEBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x127BC40", Offset = "0x127AE40", VA = "0x18127BC40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T OJKIALNGHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC6A9E0", Offset = "0xC69BE0", VA = "0x180C6A9E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T LFLEGEJLLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2CADF50", Offset = "0x2CAD150", VA = "0x182CADF50")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2CADDE0", Offset = "0x2CACFE0", VA = "0x182CADDE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float MKIGHFOLOGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xC56240", Offset = "0xC55440", VA = "0x180C56240")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5BA9470", Offset = "0x5BA8670", VA = "0x185BA9470")]
	public T OJHEPMEEGDO(float DACBPJEFOKJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5BA91F0", Offset = "0x5BA83F0", VA = "0x185BA91F0")]
	public T DGPIJLAELLA(float DACBPJEFOKJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LMNEGNLAADG(T LNELGBOPHHN, T CKNMBJOIDBN, float DACBPJEFOKJ);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A480", Offset = "0x7C19680", VA = "0x187C1A480", Slot = "4")]
	protected override float LMNEGNLAADG(float LNELGBOPHHN, float CKNMBJOIDBN, float DACBPJEFOKJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A4C0", Offset = "0x7C196C0", VA = "0x187C1A4C0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1806E90", Offset = "0x1806090", VA = "0x181806E90", Slot = "4")]
	protected override Vector3 LMNEGNLAADG(Vector3 LNELGBOPHHN, Vector3 CKNMBJOIDBN, float DACBPJEFOKJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7C1DCB0", Offset = "0x7C1CEB0", VA = "0x187C1DCB0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A080", Offset = "0x7C19280", VA = "0x187C1A080", Slot = "4")]
	protected override Color LMNEGNLAADG(Color LNELGBOPHHN, Color CKNMBJOIDBN, float DACBPJEFOKJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A140", Offset = "0x7C19340", VA = "0x187C1A140")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CCBCEPNDMLL : FPOHKNHEPGH<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A030", Offset = "0x7C19230", VA = "0x187C1A030")]
	public CCBCEPNDMLL(int POKPPHJAIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7C19FC0", Offset = "0x7C191C0", VA = "0x187C19FC0", Slot = "6")]
	protected override uint JDOFCPANENC(uint BNPHOCLLMDF, string KJIOHKMJAPE)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NILGFLAGAJH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable AIBLJDBPKAO;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public NILGFLAGAJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct JKAAEGCFHKM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> PNDFHPBIIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int HAENHMLODHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int PIEOBDGONOF;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x505ACF0", Offset = "0x5059EF0", VA = "0x18505ACF0")]
	private JKAAEGCFHKM(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> CLAMFCNKNKJ, int IMDDFJMBAJI, int DLEIIMMOIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5059200", Offset = "0x5058400", VA = "0x185059200")]
	public static JKAAEGCFHKM<T> FAHGDJGLLGD()
	{
		return default(JKAAEGCFHKM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x505A670", Offset = "0x5059870", VA = "0x18505A670")]
	public (int, int, Task<T>) OBEDGOILMDK(int MKCPMOJFGDP, [Optional] CancellationToken FHBCOAHILMJ, double GKFLGCPHKEK = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5058E80", Offset = "0x5058080", VA = "0x185058E80")]
	public void FABMCODPIGE(int MKCPMOJFGDP, int DLEIIMMOIIE, [In] T ACALKMLJJOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class FHDEFDFDFPL
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A430", Offset = "0x7C19630", VA = "0x187C1A430")]
	public static JKAAEGCFHKM<LMEKHMKKIDI> FAHGDJGLLGD()
	{
		return default(JKAAEGCFHKM<LMEKHMKKIDI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A3B0", Offset = "0x7C195B0", VA = "0x187C1A3B0")]
	public static void FABMCODPIGE([In] this JKAAEGCFHKM<LMEKHMKKIDI> IPOCHJJJBCM, int MKCPMOJFGDP, int DLEIIMMOIIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class KONHPBINCOP<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> PPECHAIEMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> NOJJJMEIAKB;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x41E64E0", Offset = "0x41E56E0", VA = "0x1841E64E0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool JNOIOHADNLB
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> PCJBOJJNOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4675300", Offset = "0x4674500", VA = "0x184675300", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> HKHNBMACGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5169E40", Offset = "0x5169040", VA = "0x185169E40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5169DA0", Offset = "0x5168FA0", VA = "0x185169DA0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5169E80", Offset = "0x5169080", VA = "0x185169E80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5169960", Offset = "0x5168B60", VA = "0x185169960")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5169450", Offset = "0x5168650", VA = "0x185169450", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5169C20", Offset = "0x5168E20", VA = "0x185169C20", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5169400", Offset = "0x5168600", VA = "0x185169400", Slot = "9")]
	public void Add(TKey MHDODBCCAJB, TVal KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x51693D0", Offset = "0x51685D0", VA = "0x1851693D0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LHNFJLFIPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x51694B0", Offset = "0x51686B0", VA = "0x1851694B0", Slot = "8")]
	public bool ContainsKey(TKey MHDODBCCAJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5169520", Offset = "0x5168720", VA = "0x185169520", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5169B50", Offset = "0x5168D50", VA = "0x185169B50", Slot = "10")]
	public bool Remove(TKey MHDODBCCAJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5169B70", Offset = "0x5168D70", VA = "0x185169B70", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5169C70", Offset = "0x5168E70", VA = "0x185169C70", Slot = "11")]
	public bool TryGetValue(TKey MHDODBCCAJB, [Out] TVal KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5169770", Offset = "0x5168970", VA = "0x185169770", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5169550", Offset = "0x5168750", VA = "0x185169550", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] KBILCKNPAKO, int NEAIGFOMGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5169720", Offset = "0x5168920", VA = "0x185169720")]
	public bool FBLKJFCBGPJ(TVal MHDODBCCAJB, [Out] TKey KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x51695C0", Offset = "0x51687C0", VA = "0x1851695C0")]
	private void DBMFOEHAPDG(TKey MHDODBCCAJB, TVal DIPIKNPCGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5169800", Offset = "0x5168A00", VA = "0x185169800")]
	private void HEFLMKNPACJ(TKey MHDODBCCAJB, TVal DIPIKNPCGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x51699B0", Offset = "0x5168BB0", VA = "0x1851699B0")]
	private bool ODACIEJEFCI(TKey MHDODBCCAJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5169CB0", Offset = "0x5168EB0", VA = "0x185169CB0")]
	public KONHPBINCOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class MJKBKJDIMGE<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private MJKBKJDIMGE<T> buffer;

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
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x1356500", Offset = "0x1355700", VA = "0x181356500", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x4757800", Offset = "0x4756A00", VA = "0x184757800", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x4757E00", Offset = "0x4757000", VA = "0x184757E00")]
		public Enumerator(MJKBKJDIMGE<T> DLBFFDJEFBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x4756220", Offset = "0x4755420", VA = "0x184756220", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x47568C0", Offset = "0x4755AC0", VA = "0x1847568C0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4755C40", Offset = "0x4754E40", VA = "0x184755C40")]
		private void GEFIMNILLOB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] ELIAJIMNNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int KOKMPCAPCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int CFBNBIMCNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int EPCDIDIGEAG;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x54247C0", Offset = "0x54239C0", VA = "0x1854247C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5425B50", Offset = "0x5424D50", VA = "0x185425B50")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5425390", Offset = "0x5424590", VA = "0x185425390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x54264D0", Offset = "0x54256D0", VA = "0x1854264D0")]
	public MJKBKJDIMGE(int POKPPHJAIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5425D60", Offset = "0x5424F60", VA = "0x185425D60")]
	public void LHOMNBOIMGH(T DACBPJEFOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x54261D0", Offset = "0x54253D0", VA = "0x1854261D0")]
	public void OLKFAGPLGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5424800", Offset = "0x5423A00", VA = "0x185424800")]
	public void EPBOMHNOJLB(int OCEHNHGKKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5424A10", Offset = "0x5423C10", VA = "0x185424A10")]
	public void GGNEAAKPFPJ(T[] KBILCKNPAKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5424780", Offset = "0x5423980", VA = "0x185424780")]
	public Enumerator BFKODFEKGDL()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5426430", Offset = "0x5425630", VA = "0x185426430", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5426430", Offset = "0x5425630", VA = "0x185426430", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5425720", Offset = "0x5424920", VA = "0x185425720")]
	private int JBOHJPBMOLE(int CMDFFDAPDIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x54261A0", Offset = "0x54253A0", VA = "0x1854261A0")]
	private int MBJBPDABNLJ(int CMDFFDAPDIB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OLAJMGFHKDD<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> DONAKHGNIBA(TRequest IKFDGIFGHKP, CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum KNEFEABMEHD
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class GPGOMBHPPEA
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float HLAKJLPEAGN = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan ILBPPFIFEIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int AAFMNEIBNMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public KNEFEABMEHD IEOPGFCKDBH;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly GPGOMBHPPEA LGHIFDBIJOC;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float JLKKIMFPANF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x4C63190", Offset = "0x4C62390", VA = "0x184C63190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan GHCHENKGMFG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4C633C0", Offset = "0x4C625C0", VA = "0x184C633C0")]
		public GPGOMBHPPEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct CAEKINIMMEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest IKFDGIFGHKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken FHBCOAHILMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> DKKCCOLBJGK;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x65ED930", Offset = "0x65ECB30", VA = "0x1865ED930")]
		public CAEKINIMMEH(TRequest IKFDGIFGHKP, TaskCompletionSource<TResult> DKKCCOLBJGK, CancellationToken FHBCOAHILMJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct NCEOACEONBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public OLAJMGFHKDD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5473040", Offset = "0x5472240", VA = "0x185473040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x54734C0", Offset = "0x54726C0", VA = "0x1854734C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct JMOIBAHFIDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public OLAJMGFHKDD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private CAEKINIMMEH <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5078EB0", Offset = "0x50780B0", VA = "0x185078EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5079FC0", Offset = "0x50791C0", VA = "0x185079FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource LKGIJPMHEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<CAEKINIMMEH> BHPFJCOFBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly GPGOMBHPPEA HCIGEMLADNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly DONAKHGNIBA HNACJAKMLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task HKOKFEMPNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int ICENDOINKCB;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x561EA10", Offset = "0x561DC10", VA = "0x18561EA10")]
	public OLAJMGFHKDD(DONAKHGNIBA HNACJAKMLKA, [Optional] GPGOMBHPPEA HCIGEMLADNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x561D110", Offset = "0x561C310", VA = "0x18561D110")]
	public Task<TResult> BIMPEHKFJNA(TRequest IKFDGIFGHKP, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x561DD20", Offset = "0x561CF20", VA = "0x18561DD20")]
	private void FPEMDBHLDCC(CAEKINIMMEH HMPLDFHHJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x561D8E0", Offset = "0x561CAE0", VA = "0x18561D8E0")]
	[AsyncStateMachine(typeof(OLAJMGFHKDD<, >.NCEOACEONBL))]
	private Task FBGPGALLHJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x561E0D0", Offset = "0x561D2D0", VA = "0x18561E0D0")]
	private CAEKINIMMEH IFOGNOGAFHD()
	{
		return default(CAEKINIMMEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x561D9B0", Offset = "0x561CBB0", VA = "0x18561D9B0")]
	[AsyncStateMachine(typeof(OLAJMGFHKDD<, >.JMOIBAHFIDH))]
	private Task FBMOPOAMEJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x561E5D0", Offset = "0x561D7D0", VA = "0x18561E5D0")]
	private void JBHJDIOCPLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x561D700", Offset = "0x561C900", VA = "0x18561D700", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface IRRUISpriteLookup
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryFindSpriteByName(string spriteName, [Out] Sprite sprite);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class MFNIPEOHEFI<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> CFFEIIKPOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> LFGBPPNFMPL;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x41E64E0", Offset = "0x41E56E0", VA = "0x1841E64E0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool JNOIOHADNLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5044CA0", Offset = "0x5043EA0", VA = "0x185044CA0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5400450", Offset = "0x53FF650", VA = "0x185400450", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x420F0F0", Offset = "0x420E2F0", VA = "0x18420F0F0", Slot = "11")]
	public void Add(T LHNFJLFIPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x53FFCB0", Offset = "0x53FEEB0", VA = "0x1853FFCB0")]
	public bool DMFHIBAECIB(T LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5400170", Offset = "0x53FF370", VA = "0x185400170", Slot = "15")]
	public bool Remove(T LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4B212C0", Offset = "0x4B204C0", VA = "0x184B212C0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4B9E370", Offset = "0x4B9D570", VA = "0x184B9E370", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x53FFBE0", Offset = "0x53FEDE0", VA = "0x1853FFBE0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x53FFC40", Offset = "0x53FEE40", VA = "0x1853FFC40", Slot = "13")]
	public bool Contains(T LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x53FFC80", Offset = "0x53FEE80", VA = "0x1853FFC80", Slot = "14")]
	public void CopyTo(T[] KBILCKNPAKO, int NEAIGFOMGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x51AD800", Offset = "0x51ACA00", VA = "0x1851AD800", Slot = "6")]
	public int IndexOf(T LHNFJLFIPMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x53FFE10", Offset = "0x53FF010", VA = "0x1853FFE10", Slot = "7")]
	public void Insert(int CMDFFDAPDIB, T LHNFJLFIPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5400090", Offset = "0x53FF290", VA = "0x185400090", Slot = "8")]
	public void RemoveAt(int CMDFFDAPDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5400290", Offset = "0x53FF490", VA = "0x185400290")]
	public MFNIPEOHEFI()
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
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x2B1B790", Offset = "0x2B1A990", VA = "0x182B1B790")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D250", Offset = "0x7C1C450", VA = "0x187C1D250")]
		public SerializedGuid([In] Guid DJOIAEMCFDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D110", Offset = "0x7C1C310", VA = "0x187C1D110")]
		public static SerializedGuid FLCKPKIALKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D0A0", Offset = "0x7C1C2A0", VA = "0x187C1D0A0")]
		public static SerializedGuid FDPODJIADBE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7C1CF40", Offset = "0x7C1C140", VA = "0x187C1CF40")]
		public bool AEOGNGCAJFN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D220", Offset = "0x7C1C420", VA = "0x187C1D220", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D1A0", Offset = "0x7C1C3A0", VA = "0x187C1D1A0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7C1CFD0", Offset = "0x7C1C1D0", VA = "0x187C1CFD0", Slot = "7")]
		public bool Equals(SerializedGuid CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D010", Offset = "0x7C1C210", VA = "0x187C1D010", Slot = "0")]
		public override bool Equals(object KFMNDOMPAMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D190", Offset = "0x7C1C390", VA = "0x187C1D190", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7C1CFA0", Offset = "0x7C1C1A0", VA = "0x187C1CFA0", Slot = "6")]
		public int CompareTo(SerializedGuid CMOCFNBHPLJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class HBBLOPBOGMJ : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type DLNENCGMPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string BAGFOMOGBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool EEMABCLBMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool MCHPOHBMKIM;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A500", Offset = "0x7C19700", VA = "0x187C1A500")]
	public HBBLOPBOGMJ(Type HPLKBFPGDOC, string KLFBONBALIL, bool CPEFHKCHDFM = false, bool HHEDKAEDMFE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface JJJEBAPAIGO<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int DFMIDCGBCMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> BAFHGDPGDCP(float MGFEHNJFHAM, [Optional] float? AOCCNEGEEDJ);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CACIBHGGFIH(float MGFEHNJFHAM, T KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OLKFAGPLGGN();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class CIDDKPHAMMG<T> : JJJEBAPAIGO<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class GKCALELPHOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float FGHKDAFDFDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T LFLEGEJLLKE;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public GKCALELPHOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class BEAIONCKNPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public BEAIONCKNPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x60C7A60", Offset = "0x60C6C60", VA = "0x1860C7A60")]
		internal bool OMEMIICPOEA(GKCALELPHOH sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float NCOKKEDNCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float FHCNOFJDLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<GKCALELPHOH> IHKANDHLALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private BHPEGABBGGH<GKCALELPHOH> NOGDCAFMEEF;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int DFMIDCGBCMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x67A5BC0", Offset = "0x67A4DC0", VA = "0x1867A5BC0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x67A66D0", Offset = "0x67A58D0", VA = "0x1867A66D0")]
	public CIDDKPHAMMG(float NPNLPMIJGIF, float PFKJLLCFJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x67A6260", Offset = "0x67A5460", VA = "0x1867A6260", Slot = "6")]
	public bool CACIBHGGFIH(float MGFEHNJFHAM, T KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x67A5F80", Offset = "0x67A5180", VA = "0x1867A5F80", Slot = "5")]
	public IEnumerable<T> BAFHGDPGDCP(float MGFEHNJFHAM, float? AOCCNEGEEDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x67A6670", Offset = "0x67A5870", VA = "0x1867A6670", Slot = "7")]
	public void OLKFAGPLGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x67A6530", Offset = "0x67A5730", VA = "0x1867A6530")]
	private void LJCCLMLPDAB(float MGFEHNJFHAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class GNFCDJDJFBB<T> : JJJEBAPAIGO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct MLGNJBHCBEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T LFLEGEJLLKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float FGHKDAFDFDB;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4C973A0", Offset = "0x4C965A0", VA = "0x184C973A0")]
		public MLGNJBHCBEI(T KJIOHKMJAPE, float MGFEHNJFHAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class MIFMFHLOFHJ : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
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
		public GNFCDJDJFBB<T> <>4__this;

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
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xED9970", Offset = "0xED8B70", VA = "0x180ED9970")]
		[DebuggerHidden]
		public MIFMFHLOFHJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5420CC0", Offset = "0x541FEC0", VA = "0x185420CC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5421030", Offset = "0x5420230", VA = "0x185421030", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5420E60", Offset = "0x5420060", VA = "0x185420E60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4BC2600", Offset = "0x4BC1800", VA = "0x184BC2600", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float NPNLPMIJGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float PFKJLLCFJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<MLGNJBHCBEI> IHKANDHLALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int KOKMPCAPCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int FGPEODKLLFN;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int DFMIDCGBCMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA036F0", Offset = "0xA028F0", VA = "0x180A036F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4C2DA80", Offset = "0x4C2CC80", VA = "0x184C2DA80")]
	public GNFCDJDJFBB(float NPNLPMIJGIF, float PFKJLLCFJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D2F0", Offset = "0x4C2C4F0", VA = "0x184C2D2F0", Slot = "6")]
	public bool CACIBHGGFIH(float MGFEHNJFHAM, T KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D680", Offset = "0x4C2C880", VA = "0x184C2D680", Slot = "8")]
	public int IKAFADNEFPB(float MGFEHNJFHAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4C2CF60", Offset = "0x4C2C160", VA = "0x184C2CF60", Slot = "5")]
	[IteratorStateMachine(typeof(GNFCDJDJFBB<>.MIFMFHLOFHJ))]
	public IEnumerable<T> BAFHGDPGDCP(float MGFEHNJFHAM, float? AOCCNEGEEDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D840", Offset = "0x4C2CA40", VA = "0x184C2D840", Slot = "7")]
	public void OLKFAGPLGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D770", Offset = "0x4C2C970", VA = "0x184C2D770")]
	private void LIJLLPCGONF(float MGFEHNJFHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D530", Offset = "0x4C2C730", VA = "0x184C2D530")]
	private MLGNJBHCBEI HKNFIAGLAOD()
	{
		return default(MLGNJBHCBEI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class BGHCJGPGCNF<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct NAFFEMJCKOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long HDNKIPJEFLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long AMAHDBIGMOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int ANFNAKHBCNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int DJEKFBICBDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool PLNPLIHJPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string FAPMBMMADIA;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x546E520", Offset = "0x546D720", VA = "0x18546E520")]
		public NAFFEMJCKOP(long HDNKIPJEFLG, int ANFNAKHBCNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x546E4F0", Offset = "0x546D6F0", VA = "0x18546E4F0")]
		public NAFFEMJCKOP(long HDNKIPJEFLG, long AMAHDBIGMOJ, int ANFNAKHBCNJ, int DJEKFBICBDF, bool PLNPLIHJPHO, string FAPMBMMADIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x546E440", Offset = "0x546D640", VA = "0x18546E440")]
		public int ODOHLEHELEJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x546E380", Offset = "0x546D580", VA = "0x18546E380")]
		public int AGFJBGFFLLL(int OHGODGPLABO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x546E490", Offset = "0x546D690", VA = "0x18546E490")]
		public double OOEDHFHBKBF()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x546E3A0", Offset = "0x546D5A0", VA = "0x18546E3A0")]
		public NAFFEMJCKOP KGBENFNLNCP(long AMAHDBIGMOJ, int DJEKFBICBDF)
		{
			return default(NAFFEMJCKOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class IPAINGKGFDM : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct DGBIJMHFPJF<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public IPAINGKGFDM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<IPAINGKGFDM, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private IPAINGKGFDM <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x420C8D0", Offset = "0x420BAD0", VA = "0x18420C8D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x420CDD0", Offset = "0x420BFD0", VA = "0x18420CDD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey JLFEKHMMFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly BGHCJGPGCNF<TKey> LAEALHELJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly KEPOMIIOHBM EBHKLAMEJCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<IPAINGKGFDM> NBPHJLEMEGF;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string PGPBMAHELKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x4E0F900", Offset = "0x4E0EB00", VA = "0x184E0F900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<IPAINGKGFDM> LCLFLBDOHNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x4E0F930", Offset = "0x4E0EB30", VA = "0x184E0F930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public NAFFEMJCKOP HEPMJFFFOLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x4E0F960", Offset = "0x4E0EB60", VA = "0x184E0F960")]
			[CompilerGenerated]
			get
			{
				return default(NAFFEMJCKOP);
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x4E0F980", Offset = "0x4E0EB80", VA = "0x184E0F980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4E0F9B0", Offset = "0x4E0EBB0", VA = "0x184E0F9B0")]
		internal IPAINGKGFDM(BGHCJGPGCNF<TKey> LAEALHELJKO, TKey MHDODBCCAJB, KEPOMIIOHBM EBHKLAMEJCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4E0F7B0", Offset = "0x4E0E9B0", VA = "0x184E0F7B0")]
		public IPAINGKGFDM ILMBENFFACJ(TKey MHDODBCCAJB, [Optional] KEPOMIIOHBM? BJFBKNJBPHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4104E50", Offset = "0x4104050", VA = "0x184104E50")]
		[AsyncStateMachine(typeof(DGBIJMHFPJF<>))]
		public Task<T> MKMOBKFPFAC<T>(TKey MHDODBCCAJB, Func<IPAINGKGFDM, Task<T>> PJBCEMJEHFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4E0F5D0", Offset = "0x4E0E7D0", VA = "0x184E0F5D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class NMCIAMPECEE : IEnumerable<(TKey, List<TKey>, NAFFEMJCKOP)>, IEnumerable, IEnumerator<(TKey, List<TKey>, NAFFEMJCKOP)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, NAFFEMJCKOP timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public BGHCJGPGCNF<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, NAFFEMJCKOP timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, NAFFEMJCKOP) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2B088C0", Offset = "0x2B07AC0", VA = "0x182B088C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, NAFFEMJCKOP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x549FEF0", Offset = "0x549F0F0", VA = "0x18549FEF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2B089B0", Offset = "0x2B07BB0", VA = "0x182B089B0")]
		[DebuggerHidden]
		public NMCIAMPECEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4B379B0", Offset = "0x4B36BB0", VA = "0x184B379B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x549F990", Offset = "0x549EB90", VA = "0x18549F990", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x549F8D0", Offset = "0x549EAD0", VA = "0x18549F8D0")]
		private void DOCBGIOIEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x549FEA0", Offset = "0x549F0A0", VA = "0x18549FEA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x549FDE0", Offset = "0x549EFE0", VA = "0x18549FDE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, NAFFEMJCKOP)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x42480A0", Offset = "0x42472A0", VA = "0x1842480A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class LOKFOPBKANB : IEnumerable<(TKey, List<TKey>, NAFFEMJCKOP)>, IEnumerable, IEnumerator<(TKey, List<TKey>, NAFFEMJCKOP)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, NAFFEMJCKOP timerEntry) <>2__current;

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
		private IPAINGKGFDM timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IPAINGKGFDM <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public BGHCJGPGCNF<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<IPAINGKGFDM> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, NAFFEMJCKOP timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, NAFFEMJCKOP) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x2B088C0", Offset = "0x2B07AC0", VA = "0x182B088C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, NAFFEMJCKOP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x52300E0", Offset = "0x522F2E0", VA = "0x1852300E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2B089B0", Offset = "0x2B07BB0", VA = "0x182B089B0")]
		[DebuggerHidden]
		public LOKFOPBKANB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5230140", Offset = "0x522F340", VA = "0x185230140", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x522F820", Offset = "0x522EA20", VA = "0x18522F820", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x522F760", Offset = "0x522E960", VA = "0x18522F760")]
		private void DOCBGIOIEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x522F7C0", Offset = "0x522E9C0", VA = "0x18522F7C0")]
		private void GHEPLDLLGGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5230090", Offset = "0x522F290", VA = "0x185230090", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x522FF80", Offset = "0x522F180", VA = "0x18522FF80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, NAFFEMJCKOP)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5230060", Offset = "0x522F260", VA = "0x185230060", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, NAFFEMJCKOP, KEPOMIIOHBM> HKKDJLLPJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, NAFFEMJCKOP, KEPOMIIOHBM> BMJMKKIEFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<BGHCJGPGCNF<TKey>, KEPOMIIOHBM> OOMBMFJEHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly IPAINGKGFDM DJHBNCIIFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool OLFOBLPNEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int JNLEIPFMBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch LECALCPHIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int MAIPADKOBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string EILLHPDFKIE;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public IPAINGKGFDM EHHDDDOFIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string PGPBMAHELKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA00360", Offset = "0x9FF560", VA = "0x180A00360")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6193C50", Offset = "0x6192E50", VA = "0x186193C50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6193D30", Offset = "0x6192F30", VA = "0x186193D30")]
	public BGHCJGPGCNF(TKey LGNKFAELEND, KEPOMIIOHBM EBHKLAMEJCE, [Optional] int? ANFNAKHBCNJ, [Optional][CanBeNull] Stopwatch LECALCPHIME, [Optional] Action<TKey, NAFFEMJCKOP, KEPOMIIOHBM> HKKDJLLPJEG, [Optional] Action<TKey, NAFFEMJCKOP, KEPOMIIOHBM> BMJMKKIEFOB, [Optional] Action<BGHCJGPGCNF<TKey>, KEPOMIIOHBM> OOMBMFJEHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6193A60", Offset = "0x6192C60", VA = "0x186193A60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6193BC0", Offset = "0x6192DC0", VA = "0x186193BC0")]
	[IteratorStateMachine(typeof(BGHCJGPGCNF<>.NMCIAMPECEE))]
	public IEnumerable<(TKey, List<TKey>, NAFFEMJCKOP)> IGCPHPNCPMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6193AF0", Offset = "0x6192CF0", VA = "0x186193AF0")]
	[IteratorStateMachine(typeof(BGHCJGPGCNF<>.LOKFOPBKANB))]
	private IEnumerable<(TKey, List<TKey>, NAFFEMJCKOP)> IGCPHPNCPMO(List<TKey> BLOCNHOFANF, IPAINGKGFDM DBFPGNMMCPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6193CB0", Offset = "0x6192EB0", VA = "0x186193CB0")]
	private (long, int) OPLCOBOALHH()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class AHLKEMCAGMO<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut GIEHMPHGEFA(BGHCJGPGCNF<TKey> LAEALHELJKO);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	protected AHLKEMCAGMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class BFEJAEDEMKG<TKey> : AHLKEMCAGMO<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate string CNKBMLMANFC(TKey MHDODBCCAJB);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6191AF0", Offset = "0x6190CF0", VA = "0x186191AF0")]
	private static string KOKMLPLICII(TKey MHDODBCCAJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6191900", Offset = "0x6190B00", VA = "0x186191900", Slot = "4")]
	public override string GIEHMPHGEFA(BGHCJGPGCNF<TKey> LAEALHELJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x61919B0", Offset = "0x6190BB0", VA = "0x1861919B0")]
	public string GIEHMPHGEFA(BGHCJGPGCNF<TKey> LAEALHELJKO, [NotNull] CNKBMLMANFC MKAPIJNHDPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string MJEDAEHOJEP(BGHCJGPGCNF<TKey> LAEALHELJKO, [NotNull] CNKBMLMANFC MKAPIJNHDPF);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x464FDA0", Offset = "0x464EFA0", VA = "0x18464FDA0")]
	protected BFEJAEDEMKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class ALOCKONANJP<TKey> : AHLKEMCAGMO<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate string GEHKIHDKMPD(TKey MHDODBCCAJB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string NDDHHLNLGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double BNHEEBJAJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool CKGHJCBBEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int LPNKLDGHEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> CKBNEGCEIKD;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5009EF0", Offset = "0x50090F0", VA = "0x185009EF0")]
	private static string KOKMLPLICII(TKey MHDODBCCAJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5009F30", Offset = "0x5009130", VA = "0x185009F30")]
	public ALOCKONANJP(string NDDHHLNLGNE = "F2", double BNHEEBJAJGA = double.MaxValue, bool CKGHJCBBEIH = false, int LPNKLDGHEGO = int.MaxValue, [Optional] ISet<string> CKBNEGCEIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5009680", Offset = "0x5008880", VA = "0x185009680", Slot = "4")]
	public override Dictionary<string, string> GIEHMPHGEFA(BGHCJGPGCNF<TKey> LAEALHELJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x50095A0", Offset = "0x50087A0", VA = "0x1850095A0")]
	private bool DJPACDIMDPK(string DFMIHOALFBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5009730", Offset = "0x5008930", VA = "0x185009730")]
	public Dictionary<string, string> GIEHMPHGEFA(BGHCJGPGCNF<TKey> LAEALHELJKO, GEHKIHDKMPD MKAPIJNHDPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5009CE0", Offset = "0x5008EE0", VA = "0x185009CE0")]
	private string HKIIJIGNIEC(StringBuilder MOICPPNKIAN, List<TKey> HMBGPOLFPGJ, GEHKIHDKMPD MKAPIJNHDPF, bool INAPJEHMOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5009440", Offset = "0x5008640", VA = "0x185009440")]
	private static void DDGLOIHPLHI(StringBuilder BEHPHECHHCL, string EOANEDFEPPJ, bool BMABCAPKMGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class EPHHIJKHDNI<TKey> : BFEJAEDEMKG<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct BOEAALNBHNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CNKBMLMANFC keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static EPHHIJKHDNI<TKey> AIBLJDBPKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] LDCMNJHEIGA;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x46ED5A0", Offset = "0x46EC7A0", VA = "0x1846ED5A0")]
	private EPHHIJKHDNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x46EC550", Offset = "0x46EB750", VA = "0x1846EC550", Slot = "5")]
	protected override string MJEDAEHOJEP(BGHCJGPGCNF<TKey> LAEALHELJKO, CNKBMLMANFC MKAPIJNHDPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x46ED380", Offset = "0x46EC580", VA = "0x1846ED380")]
	[CompilerGenerated]
	internal static string PICJMGMDOPG(string FCPAAANFFON, TKey MHDODBCCAJB, BOEAALNBHNF P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class LJLHHPLEGJA : BGHCJGPGCNF<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class BBGFLCOFMPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<LJLHHPLEGJA, KEPOMIIOHBM> callback;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public BBGFLCOFMPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7C19F30", Offset = "0x7C19130", VA = "0x187C19F30")]
		internal void LGPCKMBEMJE(BGHCJGPGCNF<string> timer, KEPOMIIOHBM log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B1F0", Offset = "0x7C1A3F0", VA = "0x187C1B1F0")]
	public LJLHHPLEGJA(KEPOMIIOHBM EBHKLAMEJCE, [Optional] string EHJIGHHBKOC, [Optional] int? ANFNAKHBCNJ, [Optional] Stopwatch LECALCPHIME, [Optional] Action<string, NAFFEMJCKOP, KEPOMIIOHBM> HKKDJLLPJEG, [Optional] Action<string, NAFFEMJCKOP, KEPOMIIOHBM> BMJMKKIEFOB, [Optional] Action<LJLHHPLEGJA, KEPOMIIOHBM> OOMBMFJEHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B130", Offset = "0x7C1A330", VA = "0x187C1B130")]
	private static Action<BGHCJGPGCNF<string>, KEPOMIIOHBM> CHHFPJHFPLM(Action<LJLHHPLEGJA, KEPOMIIOHBM> MHPGHAHOBNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public abstract class HCCLMHAFDLM
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class ELLPPCOGHEJ : HCCLMHAFDLM
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static HCCLMHAFDLM AIBLJDBPKAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x7C1A180", Offset = "0x7C19380", VA = "0x187C1A180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float HEMKOIGOAKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x121A140", Offset = "0x1219340", VA = "0x18121A140", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A270", Offset = "0x7C19470", VA = "0x187C1A270")]
		public ELLPPCOGHEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static HCCLMHAFDLM DJMCMGDKLII;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static HCCLMHAFDLM LGHIFDBIJOC
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A570", Offset = "0x7C19770", VA = "0x187C1A570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float HEMKOIGOAKA
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	protected HCCLMHAFDLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface LCHNAMIBFHG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool OIFFEBPIEBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface HLHLINEFKHE<T> : LCHNAMIBFHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> BGFIFFKAHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	GFHJFJDJPFP<T> MDECBJCIJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class NLBCBHOOFCG
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3B61A60", Offset = "0x3B60C60", VA = "0x183B61A60")]
	public static HLHLINEFKHE<TResource> NDNMBFLGGPI<TResource, TId>(this CEJFLAGAABB<TId, TResource> CIJAONNPDBG, TId APBCLGNDGBE, [Optional] Func<TId, CancellationToken, Task<TResource>>? HEFAIOJFJDM) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class HLNLGNIFAIF
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class HEAOJKIDGIH<T> : GJBDDJLFOPI<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> BGFIFFKAHGL
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override GFHJFJDJPFP<T?> MDECBJCIJNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x4C9CBD0", Offset = "0x4C9BDD0", VA = "0x184C9CBD0")]
		public HEAOJKIDGIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "10")]
		protected override void BOEKPCDEEIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class NOMFDFAJLJC<T> : GJBDDJLFOPI<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T NHOINDAEFNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? FLDOEIHGIDE;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> BGFIFFKAHGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xA00F50", Offset = "0xA00150", VA = "0x180A00F50", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override GFHJFJDJPFP<T> MDECBJCIJNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xA00F70", Offset = "0xA00170", VA = "0x180A00F70", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x54AA810", Offset = "0x54A9A10", VA = "0x1854AA810")]
		public NOMFDFAJLJC(T PHFFEPFKKME, Action<T>? KGIAEMKECHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x54AA670", Offset = "0x54A9870", VA = "0x1854AA670", Slot = "10")]
		protected override void BOEKPCDEEIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class OJENOMDCPAP<T> : GJBDDJLFOPI<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> BGFIFFKAHGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override GFHJFJDJPFP<T> MDECBJCIJNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x561C0F0", Offset = "0x561B2F0", VA = "0x18561C0F0")]
		public OJENOMDCPAP(Exception GMBDOBOLCOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "10")]
		protected override void BOEKPCDEEIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private sealed class HAIKKHNJIBN<T> : GJBDDJLFOPI<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct BJLKDILMCOK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<HLHLINEFKHE<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<HLHLINEFKHE<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x619F720", Offset = "0x619E920", VA = "0x18619F720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x61A00C0", Offset = "0x619F2C0", VA = "0x1861A00C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct IPHPJGNJKDM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<HLHLINEFKHE<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<HLHLINEFKHE<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x4E11230", Offset = "0x4E10430", VA = "0x184E11230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x4E11450", Offset = "0x4E10650", VA = "0x184E11450", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<HLHLINEFKHE<T>> PDAMBNLLGDP;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> BGFIFFKAHGL
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override GFHJFJDJPFP<T> MDECBJCIJNK
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x4C942A0", Offset = "0x4C934A0", VA = "0x184C942A0")]
		public HAIKKHNJIBN(Task<HLHLINEFKHE<T>> MKOPIIJMBLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4C93D40", Offset = "0x4C92F40", VA = "0x184C93D40", Slot = "10")]
		protected override void BOEKPCDEEIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x4C93F90", Offset = "0x4C93190", VA = "0x184C93F90")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(HAIKKHNJIBN<>.BJLKDILMCOK))]
		internal static Task<T> KHFKIAIOIHN(Task<HLHLINEFKHE<T>> MKOPIIJMBLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x4C941C0", Offset = "0x4C933C0", VA = "0x184C941C0")]
		[AsyncStateMachine(typeof(HAIKKHNJIBN<>.IPHPJGNJKDM))]
		[CompilerGenerated]
		internal static Task NPDHCBBKNEB(Task<HLHLINEFKHE<T>> MKOPIIJMBLM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class MGLCLGLNEFF<TIn, TOut> : GJBDDJLFOPI<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct OCHMFLLHPKP : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x55FFB90", Offset = "0x55FED90", VA = "0x1855FFB90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x5081400", Offset = "0x5080600", VA = "0x185081400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly HLHLINEFKHE<TIn> AFINADKJBKD;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> BGFIFFKAHGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override GFHJFJDJPFP<TOut> MDECBJCIJNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x5409350", Offset = "0x5408550", VA = "0x185409350")]
		public MGLCLGLNEFF(HLHLINEFKHE<TIn> ADLKKLGIHLG, Func<TIn, TOut> HPNNPJEKNLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5408FD0", Offset = "0x54081D0", VA = "0x185408FD0", Slot = "10")]
		protected override void BOEKPCDEEIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5409070", Offset = "0x5408270", VA = "0x185409070")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(MGLCLGLNEFF<, >.OCHMFLLHPKP))]
		internal static Task<TOut> DOPAKHKCINN(Task<TIn> HBHFDBNJENG, Func<TIn, TOut> HPNNPJEKNLO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3A28970", Offset = "0x3A27B70", VA = "0x183A28970")]
	public static HLHLINEFKHE<T> BCEMEONNHIA<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3A288E0", Offset = "0x3A27AE0", VA = "0x183A288E0")]
	public static HLHLINEFKHE<T> ACMIAPIEAGH<T>(T ACALKMLJJOL, [Optional] Action<T>? KGIAEMKECHL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3791E70", Offset = "0x3791070", VA = "0x183791E70")]
	public static HLHLINEFKHE<T> GAFDNCFACCC<T>(Exception GMBDOBOLCOA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3791E70", Offset = "0x3791070", VA = "0x183791E70")]
	public static HLHLINEFKHE<T> EHFIPIOICPG<T>(Task<HLHLINEFKHE<T>> MKOPIIJMBLM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2FADC80", Offset = "0x2FACE80", VA = "0x182FADC80")]
	public static HLHLINEFKHE<TOut> DEGAIHEEOBC<TOut, TIn>(HLHLINEFKHE<TIn> BIFBBDMNGPL, Func<TIn, TOut> HPNNPJEKNLO) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class GJBDDJLFOPI<T> : HLHLINEFKHE<T>, LCHNAMIBFHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string POGANIPIIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly AIBGEOBFMGI JMBPHLCDIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool OLFOBLPNEEI;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool OIFFEBPIEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA751A0", Offset = "0xA743A0", VA = "0x180A751A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> BGFIFFKAHGL
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract GFHJFJDJPFP<T> MDECBJCIJNK
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4C0C340", Offset = "0x4C0B540", VA = "0x184C0C340")]
	public GJBDDJLFOPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4C0BFB0", Offset = "0x4C0B1B0", VA = "0x184C0BFB0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void BOEKPCDEEIG();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class EDMAKCFKKAM<TTask, T> : GJBDDJLFOPI<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class NHELGDDCGGN
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
			public NHELGDDCGGN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x41CEF40", Offset = "0x41CE140", VA = "0x1841CEF40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x41CF490", Offset = "0x41CE690", VA = "0x1841CF490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public EDMAKCFKKAM<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public NHELGDDCGGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x548D480", Offset = "0x548C680", VA = "0x18548D480")]
		[AsyncStateMachine(typeof(EDMAKCFKKAM<, >.NHELGDDCGGN.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> KLGGNBJFHAA(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> MKOPIIJMBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource IHOFGGILNEH;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> BGFIFFKAHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override GFHJFJDJPFP<T> MDECBJCIJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4669860", Offset = "0x4668A60", VA = "0x184669860")]
	protected EDMAKCFKKAM(TTask MKOPIIJMBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4669810", Offset = "0x4668A10", VA = "0x184669810", Slot = "10")]
	protected override void BOEKPCDEEIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T ILKIJPCJEON(TTask HLNGIDCBKFL);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void OLLLHCCMGKM();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class EKKMDBMIFOK<T> : GJBDDJLFOPI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly MBFLJOFBBPA<Task<T>> NFHAKLKOEOO;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> BGFIFFKAHGL
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x46DEF60", Offset = "0x46DE160", VA = "0x1846DEF60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override GFHJFJDJPFP<T> MDECBJCIJNK
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x46DEFA0", Offset = "0x46DE1A0", VA = "0x1846DEFA0")]
	public EKKMDBMIFOK(MBFLJOFBBPA<Task<T>> CIPOOEBBGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x46DEF40", Offset = "0x46DE140", VA = "0x1846DEF40", Slot = "10")]
	protected override void BOEKPCDEEIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class JBFBHHOBGBC
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName FIACOMHKHON;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> IGGJDKMBOHP;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7C1AE10", Offset = "0x7C1A010", VA = "0x187C1AE10")]
	public static int NHIFFPNBNBJ(this KMNLAPLHDFO MBAANJEGLKA, IncrementalHash BNPHOCLLMDF, byte[] LIFBHMIFDPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A760", Offset = "0x7C19960", VA = "0x187C1A760")]
	public static bool LGHDEEJNGIA([CanBeNull] this KMNLAPLHDFO MBAANJEGLKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A7C0", Offset = "0x7C199C0", VA = "0x187C1A7C0")]
	public static bool LGHDEEJNGIA([CanBeNull] this KMNLAPLHDFO MBAANJEGLKA, [Out] string HKIJLMNBOAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7C1AAD0", Offset = "0x7C19CD0", VA = "0x187C1AAD0")]
	public static bool LGHDEEJNGIA([CanBeNull] this KMNLAPLHDFO MBAANJEGLKA, IncrementalHash BNPHOCLLMDF, byte[] LIFBHMIFDPO, [Out] string HKIJLMNBOAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A6D0", Offset = "0x7C198D0", VA = "0x187C1A6D0")]
	private static bool JGKNOGPLDOF(byte[] FCKMIOOFODK, Span<byte> KMIHMHOLGMO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class KOGBIFAPJHE
{
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7C1AFE0", Offset = "0x7C1A1E0", VA = "0x187C1AFE0")]
	public static int EKPDPHPFEHH(HashAlgorithmName LBOHFLPMKIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9660", Offset = "0x3AB8860", VA = "0x183AB9660")]
	public static int NHIFFPNBNBJ<T>(this T FMFFDLHBIKP, byte[] NLLAHCAMCGM, IncrementalHash BNPHOCLLMDF, byte[] OOFFKGGAKOB) where T : LPPLGHAJPJI
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface LPPLGHAJPJI
{
	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash BNPHOCLLMDF);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface KMNLAPLHDFO : LPPLGHAJPJI
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] IHNEFKGJKPG
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] PPJGIJGIAKH
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class ADOLBLEDOGH
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool DEDDLAOCFLP;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> CMDOHDKHIOF;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> FPJNBFMFCHP;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding CECFNAOKNOM;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> HPFLMKMNBMH;

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2F988D0", Offset = "0x2F97AD0", VA = "0x182F988D0")]
	public static void DAGPFOLLIJD<T>(this IncrementalHash GLABDDKHHOF, [CanBeNull] T JCAGDPHNPIB) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x2F98840", Offset = "0x2F97A40", VA = "0x182F98840")]
	public static void AKBLNHEKBJK<T>(this IncrementalHash GLABDDKHHOF, [CanBeNull] T FMFFDLHBIKP) where T : LPPLGHAJPJI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2F98FC0", Offset = "0x2F981C0", VA = "0x182F98FC0")]
	public static void NEMFAJFONLG<T>(this IncrementalHash GLABDDKHHOF, [CanBeNull] IList<T> LDNMGJAAHLG) where T : LPPLGHAJPJI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7C19590", Offset = "0x7C18790", VA = "0x187C19590")]
	private static bool INAPNEGPBBC([CanBeNull] LPPLGHAJPJI FMFFDLHBIKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7C18D90", Offset = "0x7C17F90", VA = "0x187C18D90")]
	public static void BLIKDLBHKLH(this IncrementalHash BNPHOCLLMDF, string? NOKJDMOIOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7C19680", Offset = "0x7C18880", VA = "0x187C19680")]
	public static void MFACCNMCCOL(this IncrementalHash BNPHOCLLMDF, long LIOKLBIAGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7C198B0", Offset = "0x7C18AB0", VA = "0x187C198B0")]
	public static void NHBEJANPIGN(this IncrementalHash BNPHOCLLMDF, int BKDENNNHAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7C193C0", Offset = "0x7C185C0", VA = "0x187C193C0")]
	public static void IFLGLOFJJHJ(this IncrementalHash BNPHOCLLMDF, short PIMLDHJGJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7C19A80", Offset = "0x7C18C80", VA = "0x187C19A80")]
	public static void NLHKMEPIPGM(this IncrementalHash BNPHOCLLMDF, byte GMIMLGHMOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7C19250", Offset = "0x7C18450", VA = "0x187C19250")]
	public static void ICLGKPHLMOH(this IncrementalHash BNPHOCLLMDF, bool FFPFAPNNPPG, bool NNHLHFEPDPJ = false, bool HFHJBPABAAH = false, bool HIMCENGLIMF = false, bool MGMOGPILJJG = false, bool FCIIECNAAHM = false, bool FEJKKPJAGKL = false, bool BAFGPNENHMJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x2F98990", Offset = "0x2F97B90", VA = "0x182F98990")]
	public static void FJJEENIKCOC<T>(this IncrementalHash BNPHOCLLMDF, T GDKPICOHMLK) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7C19190", Offset = "0x7C18390", VA = "0x187C19190")]
	public static void EEBDPFPEGGO(this IncrementalHash BNPHOCLLMDF, float LMFMFJCNHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7C19850", Offset = "0x7C18A50", VA = "0x187C19850")]
	public static void NGPEICKDCME(this IncrementalHash BNPHOCLLMDF, ulong CNAFJFLBBFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7C19620", Offset = "0x7C18820", VA = "0x187C19620")]
	public static void INOLLJENFGG(this IncrementalHash BNPHOCLLMDF, uint MINIEKIJAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7C191F0", Offset = "0x7C183F0", VA = "0x187C191F0")]
	public static void HFIAPGOECKK(this IncrementalHash BNPHOCLLMDF, ushort LOKFANFMBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B90", Offset = "0x7C18D90", VA = "0x187C19B90")]
	public static void OKPPDJOPDDF(this IncrementalHash BNPHOCLLMDF, Vector3 FOMNAHFCMNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class PAJDNHEIAGN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B830", Offset = "0x7C1AA30", VA = "0x187C1B830")]
	public PAJDNHEIAGN(string NPEJLHCJPAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class GMKKMCNGHCG
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void LNJNEBOMBOC(ushort OLHPMDEGODJ, ushort NNNNFLKMGGP, ushort NKDOPHKCHFD, ushort KGKNKBFPNNF);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void FCCCIBDJFNP(ushort HPALGKEIFHE, ushort PJNKFBJNKCA);

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate void HOGCJFCICPB();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort MIKGMCCJCJD = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	protected GMKKMCNGHCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class OAKKACHLJMA<T> : GMKKMCNGHCG where T : OAKKACHLJMA<T>.BCKBJNIHIKG
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public interface BCKBJNIHIKG
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		FCCCIBDJFNP LJIADKDEOGI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		FCCCIBDJFNP LKAALFHDDIE
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		HOGCJFCICPB EKMKKOOKPLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> ODCJHJILPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private HOGCJFCICPB IMMBNLBCAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private HOGCJFCICPB AIOKPLGACAH;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool GOINMJMDKIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xB16990", Offset = "0xB15B90", VA = "0x180B16990")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA04160", Offset = "0xA03360", VA = "0x180A04160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort PHOALDFAGAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x10FABF0", Offset = "0x10F9DF0", VA = "0x1810FABF0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x10FACC0", Offset = "0x10F9EC0", VA = "0x1810FACC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort IDKNDFBDHBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x55FA290", Offset = "0x55F9490", VA = "0x1855FA290")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x55FADB0", Offset = "0x55F9FB0", VA = "0x1855FADB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort BHKPDEMOLHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xE31360", Offset = "0xE30560", VA = "0x180E31360")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xE31470", Offset = "0xE30670", VA = "0x180E31470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort CLPNOJLBLLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x55FA330", Offset = "0x55F9530", VA = "0x1855FA330")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x55FAF90", Offset = "0x55FA190", VA = "0x1855FAF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool NNKLGFMEHEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x10FAC00", Offset = "0x10F9E00", VA = "0x1810FAC00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool CCGEDHFOBNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xF230C0", Offset = "0xF222C0", VA = "0x180F230C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event LNJNEBOMBOC INIJNLBIGLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x55FAFA0", Offset = "0x55FA1A0", VA = "0x1855FAFA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x55FADC0", Offset = "0x55F9FC0", VA = "0x1855FADC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x55FA2A0", Offset = "0x55F94A0", VA = "0x1855FA2A0")]
	private T AMBPKMFIEJI(ushort FBECGGBCJHG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x55FA3E0", Offset = "0x55F95E0", VA = "0x1855FA3E0")]
	private T DCAEFNDNLLL(ushort FBECGGBCJHG, ushort DHNHCEOLDFG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x55FB040", Offset = "0x55FA240", VA = "0x1855FB040")]
	protected T OECALIKPMMH(uint JIFDOLBCELM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x55FB080", Offset = "0x55FA280", VA = "0x1855FB080")]
	protected OAKKACHLJMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x55FAF70", Offset = "0x55FA170", VA = "0x1855FAF70")]
	public void MFDDGJJLNAC(ushort AAAJOKDNHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x55FAE60", Offset = "0x55FA060", VA = "0x1855FAE60")]
	public void MFDDGJJLNAC(ushort AAAJOKDNHDG, ushort POMIKIJMDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x55FAEB0", Offset = "0x55FA0B0", VA = "0x1855FAEB0", Slot = "4")]
	protected virtual void MFDDGJJLNAC(uint KJIAOAAIDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x55FA6A0", Offset = "0x55F98A0", VA = "0x1855FA6A0")]
	protected void GMOIKFEEEEJ(uint KJIAOAAIDLO, uint MMPHPDIDGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x55FA340", Offset = "0x55F9540", VA = "0x1855FA340")]
	protected void BHGFBGFDEOC(ushort FBECGGBCJHG, ushort DHNHCEOLDFG, T CKCKEFFHJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x55FA3B0", Offset = "0x55F95B0", VA = "0x1855FA3B0")]
	private void CDFNOHFFNNK(uint JIFDOLBCELM, T CKCKEFFHJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x55FA470", Offset = "0x55F9670", VA = "0x1855FA470")]
	protected void ECFMDCJJHEA(float IDFEGEHLHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x55FADA0", Offset = "0x55F9FA0", VA = "0x1855FADA0")]
	protected uint INALIDJLKEF(ushort FBECGGBCJHG, ushort DHNHCEOLDFG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x55FAD90", Offset = "0x55F9F90", VA = "0x1855FAD90")]
	protected ushort IJBGALBCGAJ(uint LONMCFNLCKF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x55FAD80", Offset = "0x55F9F80", VA = "0x1855FAD80")]
	protected ushort ICLEJCGFMLN(uint LONMCFNLCKF)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class MGOIPGIFPLJ : OAKKACHLJMA<MGOIPGIFPLJ.PDONBPOAEAD>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class PDONBPOAEAD : BCKBJNIHIKG
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public FCCCIBDJFNP LJIADKDEOGI
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xA00FA0", Offset = "0xA001A0", VA = "0x180A00FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public FCCCIBDJFNP LKAALFHDDIE
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA00F60", Offset = "0xA00160", VA = "0x180A00F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public HOGCJFCICPB EKMKKOOKPLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA01190", Offset = "0xA00390", VA = "0x180A01190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public PDONBPOAEAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B430", Offset = "0x7C1A630", VA = "0x187C1B430")]
	public void DDAMNKFDPML(ushort BNHBCJEGPMJ, FCCCIBDJFNP KJHLEIGJICC, FCCCIBDJFNP MOHNCNAMJEK, HOGCJFCICPB LEDCAPIENNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B510", Offset = "0x7C1A710", VA = "0x187C1B510")]
	public void DDAMNKFDPML(ushort FBECGGBCJHG, ushort DHNHCEOLDFG, FCCCIBDJFNP KJHLEIGJICC, FCCCIBDJFNP MOHNCNAMJEK, HOGCJFCICPB LEDCAPIENNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B5F0", Offset = "0x7C1A7F0", VA = "0x187C1B5F0")]
	public void KJFMNLEBHBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B640", Offset = "0x7C1A840", VA = "0x187C1B640")]
	protected MGOIPGIFPLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class MHIIEDDJGIL : MGOIPGIFPLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool APNNLDCNEPI;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool CFMEGCKFFEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xC777C0", Offset = "0xC769C0", VA = "0x180C777C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xD714B0", Offset = "0xD706B0", VA = "0x180D714B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B680", Offset = "0x7C1A880", VA = "0x187C1B680")]
	public void AFLILFPIJAH(ushort KPEJKBJOOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B6E0", Offset = "0x7C1A8E0", VA = "0x187C1B6E0")]
	public void AFLILFPIJAH(ushort KPEJKBJOOPO, ushort CPOCCFPOEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B640", Offset = "0x7C1A840", VA = "0x187C1B640")]
	public MHIIEDDJGIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class HOLFEKKHLOE<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal class HFGEKFDEMOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode IPOCHJJJBCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode FLKKOCNDECC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public NLMHOPOPNNN IMMAKBDNFNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<NLMHOPOPNNN> PLJOHMECELM;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public HFGEKFDEMOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal struct NLMHOPOPNNN : IComparable<NLMHOPOPNNN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int JKPJMPOAKPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant DBANAPMAACB;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x174AAF0", Offset = "0x1749CF0", VA = "0x18174AAF0")]
		public NLMHOPOPNNN(int JKPJMPOAKPP, TClaimant DBANAPMAACB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x549F7F0", Offset = "0x549E9F0", VA = "0x18549F7F0")]
		public bool MHAIPKJKDNM([In] NLMHOPOPNNN CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x549F850", Offset = "0x549EA50", VA = "0x18549F850")]
		public bool PLCDLFHGMON([In] NLMHOPOPNNN CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x549F7E0", Offset = "0x549E9E0", VA = "0x18549F7E0", Slot = "4")]
		public int CompareTo(NLMHOPOPNNN CMOCFNBHPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x549F860", Offset = "0x549EA60", VA = "0x18549F860", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum AGGJMGJGMCH
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class CONBFEBBPKE : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public HOLFEKKHLOE<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xED9970", Offset = "0xED8B70", VA = "0x180ED9970")]
		[DebuggerHidden]
		public CONBFEBBPKE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6878B40", Offset = "0x6877D40", VA = "0x186878B40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6878D00", Offset = "0x6877F00", VA = "0x186878D00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6878C20", Offset = "0x6877E20", VA = "0x186878C20", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x4B776E0", Offset = "0x4B768E0", VA = "0x184B776E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly BHPEGABBGGH<HFGEKFDEMOD> MNCFLLCJFKH;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly BHPEGABBGGH<List<NLMHOPOPNNN>> NBLOEDOCAAJ;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int JOPJGLOMMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> DFMGFFNLOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, HFGEKFDEMOD> MPBBDOJLEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private AGGJMGJGMCH CPNALAHLBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool JDKAOICAPKG;

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode JMBNDFCBJBM(TNode HFACGLFOMBB);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void EEAOAADBOEJ(TNode HFACGLFOMBB, TClaimant FNGMHEOLIJM, TClaimant JHEGCJEKBDE);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4CECD90", Offset = "0x4CEBF90", VA = "0x184CECD90")]
	public HOLFEKKHLOE(AGGJMGJGMCH CPNALAHLBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4CEC6F0", Offset = "0x4CEB8F0", VA = "0x184CEC6F0")]
	public void KBKMPEGBJJM(TNode HFACGLFOMBB, TNode DAFAJHDHOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4CEB670", Offset = "0x4CEA870", VA = "0x184CEB670")]
	public void AACBPKBHMLP(TClaimant DBANAPMAACB, TNode MCLJPMKOKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4CEBD80", Offset = "0x4CEAF80", VA = "0x184CEBD80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4CEC4C0", Offset = "0x4CEB6C0", VA = "0x184CEC4C0")]
	private void FLKNPIMBKOJ(TClaimant DBANAPMAACB, TNode PAFJGAKEBFA, TNode MCLJPMKOKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4CEBC30", Offset = "0x4CEAE30", VA = "0x184CEBC30")]
	private int BNCMNKBBAPM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4CEC1A0", Offset = "0x4CEB3A0", VA = "0x184CEC1A0")]
	private void FILJCNANMBD(TClaimant DBANAPMAACB, TNode HOCLDKEDOLG, TNode GDOJBHEJNHO, int BBHNGOIGAFC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4CEC670", Offset = "0x4CEB870", VA = "0x184CEC670")]
	private void HHEAAJEPBFG(NLMHOPOPNNN ENAGNFCNIHF, HFGEKFDEMOD DDCBOGLJKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4CEC850", Offset = "0x4CEBA50", VA = "0x184CEC850")]
	private void LPKHKGMIFEO(TClaimant DBANAPMAACB, TNode HOCLDKEDOLG, TNode GDOJBHEJNHO, int BBHNGOIGAFC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4CEC560", Offset = "0x4CEB760", VA = "0x184CEC560")]
	private void GBBFNEOCOLN(NLMHOPOPNNN ENAGNFCNIHF, TNode HFACGLFOMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x4CEBCA0", Offset = "0x4CEAEA0", VA = "0x184CEBCA0")]
	private void DACIPLOIKLO(NLMHOPOPNNN ENAGNFCNIHF, HFGEKFDEMOD DDCBOGLJKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x4CEC080", Offset = "0x4CEB280", VA = "0x184CEC080")]
	private void ELHDPEJHEPC(HFGEKFDEMOD DDCBOGLJKIC, bool GMIDKKMKLEI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x4CEB8E0", Offset = "0x4CEAAE0", VA = "0x184CEB8E0")]
	private void APJADHEKONK(HFGEKFDEMOD DDCBOGLJKIC, TNode DAFAJHDHOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x4CEC780", Offset = "0x4CEB980", VA = "0x184CEC780")]
	[IteratorStateMachine(typeof(HOLFEKKHLOE<, >.CONBFEBBPKE))]
	private IEnumerable<TNode> LGHFNHEDPNL(TNode HOCLDKEDOLG, TNode GDOJBHEJNHO, bool KKOHJHNJJCN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x4CECB10", Offset = "0x4CEBD10", VA = "0x184CECB10")]
	private HFGEKFDEMOD PIENNJEHJIF(TNode HFACGLFOMBB, TNode FLKKOCNDECC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x4CEB790", Offset = "0x4CEA990", VA = "0x184CEB790")]
	private HFGEKFDEMOD ANFFBNOACCA(TNode HFACGLFOMBB, TNode FLKKOCNDECC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x4CEBF20", Offset = "0x4CEB120", VA = "0x184CEBF20")]
	private void EBKEHDBOHOC(HFGEKFDEMOD DDCBOGLJKIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class FPOHKNHEPGH<T> : IEnumerable<FPOHKNHEPGH<T>.DCOGMCMILON>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public struct DCOGMCMILON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T KJIOHKMJAPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int CMDFFDAPDIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class DILIIGLNDIP : IEnumerator<DCOGMCMILON>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private FPOHKNHEPGH<T> ABMKJAEMGBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int CMDFFDAPDIB;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x4212BC0", Offset = "0x4211DC0", VA = "0x184212BC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public DCOGMCMILON FJFNMMOOKII
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x4212D90", Offset = "0x4211F90", VA = "0x184212D90", Slot = "4")]
			get
			{
				return default(DCOGMCMILON);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x4212CA0", Offset = "0x4211EA0", VA = "0x184212CA0")]
		public DILIIGLNDIP(FPOHKNHEPGH<T> ABMKJAEMGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4212B30", Offset = "0x4211D30", VA = "0x184212B30", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x4212BB0", Offset = "0x4211DB0", VA = "0x184212BB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x1187CA0", Offset = "0x1186EA0", VA = "0x181187CA0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private struct LKAMEBFOBCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool OBPNNFGIMCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T KJIOHKMJAPE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int JFOJMFBLCFO = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> KBBFPEEOBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private LKAMEBFOBCO[] MPAPMOFJNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int ELFMFDNBKPA;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int JGENJBJJABA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA674B0", Offset = "0xA666B0", VA = "0x180A674B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xF45280", Offset = "0xF44480", VA = "0x180F45280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x41E64E0", Offset = "0x41E56E0", VA = "0x1841E64E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x4B4CFF0", Offset = "0x4B4C1F0", VA = "0x184B4CFF0")]
	public FPOHKNHEPGH(int POKPPHJAIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x4B4CC40", Offset = "0x4B4BE40", VA = "0x184B4CC40")]
	public FPOHKNHEPGH(DCOGMCMILON[] COEJDNMFEGI, bool NDKMIHHBCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4B4C6B0", Offset = "0x4B4B8B0", VA = "0x184B4C6B0")]
	public int MDIEILHHAIH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4B4BDA0", Offset = "0x4B4AFA0", VA = "0x184B4BDA0")]
	private int DCBHOEOLMIA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4B4C540", Offset = "0x4B4B740", VA = "0x184B4C540", Slot = "6")]
	protected virtual uint JDOFCPANENC(uint BNPHOCLLMDF, T KJIOHKMJAPE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4B4C620", Offset = "0x4B4B820", VA = "0x184B4C620")]
	public bool LGBKGMAOMHF(T KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4B4C790", Offset = "0x4B4B990", VA = "0x184B4C790")]
	public int NCPKFPABHIA(T KJIOHKMJAPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4B4C560", Offset = "0x4B4B760", VA = "0x184B4C560")]
	public T JKBBNFBIFNP(int CMDFFDAPDIB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4B4C1E0", Offset = "0x4B4B3E0", VA = "0x184B4C1E0")]
	public bool DMFHIBAECIB(T KJIOHKMJAPE, bool EEKLLEHHDAO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4B4C230", Offset = "0x4B4B430", VA = "0x184B4C230")]
	public bool DMFHIBAECIB(T KJIOHKMJAPE, int CMDFFDAPDIB, bool EEKLLEHHDAO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4B4C470", Offset = "0x4B4B670", VA = "0x184B4C470")]
	private int FKACGKFMILN(int KOKMPCAPCJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4B4C800", Offset = "0x4B4BA00", VA = "0x184B4C800", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4B4C800", Offset = "0x4B4BA00", VA = "0x184B4C800", Slot = "4")]
	private IEnumerator<DCOGMCMILON> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class BHPEGABBGGH<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> LNBOHLIJCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> PIEDIGHCGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int BOGPADKAENF;

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x61997A0", Offset = "0x61989A0", VA = "0x1861997A0")]
	public static BHPEGABBGGH<T> ILJNPNEAHEB(int POKPPHJAIGN = 0, int BOGPADKAENF = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x61994B0", Offset = "0x61986B0", VA = "0x1861994B0")]
	public static BHPEGABBGGH<T> CHDABCGLCPO(int POKPPHJAIGN = 0, int BOGPADKAENF = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6199E70", Offset = "0x6199070", VA = "0x186199E70")]
	public BHPEGABBGGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6199CE0", Offset = "0x6198EE0", VA = "0x186199CE0")]
	public BHPEGABBGGH(int POKPPHJAIGN, int BOGPADKAENF = int.MaxValue, bool HHNBGAJCGKG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6199880", Offset = "0x6198A80", VA = "0x186199880")]
	public T KKGIPBEMGOM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6199BF0", Offset = "0x6198DF0", VA = "0x186199BF0")]
	public void NCGHJFCANHM(T KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x61996D0", Offset = "0x61988D0", VA = "0x1861996D0")]
	private void GHLLAMGFMMK(T KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6199CC0", Offset = "0x6198EC0", VA = "0x186199CC0")]
	private void PLFFPPJFNHI(T KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6199590", Offset = "0x6198790", VA = "0x186199590", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6199A00", Offset = "0x6198C00", VA = "0x186199A00")]
	private void MKEPIGNHOOG(IEnumerable<T> LMKJLPPFOFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class HOFBINCGPMI<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> MGGGOEHGEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T MLDIKKECPEE;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T KFGBIDOLNCC
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xA00F60", Offset = "0xA00160", VA = "0x180A00F60", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4CEAE90", Offset = "0x4CEA090", VA = "0x184CEAE90")]
	public bool PAMMCPIPILF(T KJIOHKMJAPE, int JKPJMPOAKPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4CEA7C0", Offset = "0x4CE99C0", VA = "0x184CEA7C0")]
	public bool ADCJALNBKOH(int JKPJMPOAKPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x4CEAA20", Offset = "0x4CE9C20", VA = "0x184CEAA20")]
	public T DHPPGCPCAJM(int LPJIBEAJOHM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x4CEAC40", Offset = "0x4CE9E40", VA = "0x184CEAC40")]
	private bool FHCDFBMOPKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x4CEAC00", Offset = "0x4CE9E00", VA = "0x184CEAC00")]
	public bool FBLKJFCBGPJ(int JKPJMPOAKPP, [Out] T KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x4CEAF00", Offset = "0x4CEA100", VA = "0x184CEAF00")]
	public HOFBINCGPMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class FBIAMPEAOOG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	protected struct GFDOPMCCFDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T LFLEGEJLLKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int OBFEBJHFBGN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<GFDOPMCCFDL> ELIAJIMNNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T ABBCGOJMFLK;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x41E64E0", Offset = "0x41E56E0", VA = "0x1841E64E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x4B21B80", Offset = "0x4B20D80", VA = "0x184B21B80")]
	public bool NJCAMOKKLGF(T KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4B21980", Offset = "0x4B20B80", VA = "0x184B21980")]
	public void LHOMNBOIMGH(T KJIOHKMJAPE, int JKPJMPOAKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4B21F50", Offset = "0x4B21150", VA = "0x184B21F50")]
	public bool PKCJOLGDFLO(T KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4B21DC0", Offset = "0x4B20FC0", VA = "0x184B21DC0")]
	public void OLKFAGPLGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x4B21560", Offset = "0x4B20760", VA = "0x184B21560")]
	public T GGPMGDJFCMK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4B21760", Offset = "0x4B20960", VA = "0x184B21760")]
	protected void IDGOPHDDDPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x4B22100", Offset = "0x4B21300", VA = "0x184B22100")]
	public FBIAMPEAOOG()
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
		[GBCGIPBAICF(CFJMFGLCHFI.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x7C1BCA0", Offset = "0x7C1AEA0", VA = "0x187C1BCA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x7C1BF70", Offset = "0x7C1B170", VA = "0x187C1BF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7C1BE80", Offset = "0x7C1B080", VA = "0x187C1BE80")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x7C1BBF0", Offset = "0x7C1ADF0", VA = "0x187C1BBF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x7C1BEC0", Offset = "0x7C1B0C0", VA = "0x187C1BEC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x7C1BDD0", Offset = "0x7C1AFD0", VA = "0x187C1BDD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7C1BB70", Offset = "0x7C1AD70", VA = "0x187C1BB70")]
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

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x58C98A0", Offset = "0x58C8AA0", VA = "0x1858C98A0", Slot = "4")]
		public virtual T KDABOPNEOAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface GILHNHHMFHF
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	ToolHierarchyCache GMELBPHEFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
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
		public struct FCPAOIAFNJP<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private readonly List<Component> CFFEIIKPOPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private readonly bool GPDCMJFDBLI;

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x18CDBA0", Offset = "0x18CCDA0", VA = "0x1818CDBA0")]
			public FCPAOIAFNJP(List<Component> CFFEIIKPOPD, bool GPDCMJFDBLI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x4B2B700", Offset = "0x4B2A900", VA = "0x184B2B700")]
			public AJKKEAPCLIF<T> BFKODFEKGDL()
			{
				return default(AJKKEAPCLIF<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x4B2B760", Offset = "0x4B2A960", VA = "0x184B2B760", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x4B2B760", Offset = "0x4B2A960", VA = "0x184B2B760", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public struct AJKKEAPCLIF<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly List<Component> CFFEIIKPOPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private readonly bool GPDCMJFDBLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private int CMDFFDAPDIB;

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public T FJFNMMOOKII
			{
				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x4F34010", Offset = "0x4F33210", VA = "0x184F34010", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x4F33FA0", Offset = "0x4F331A0", VA = "0x184F33FA0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x4F33FE0", Offset = "0x4F331E0", VA = "0x184F33FE0")]
			public AJKKEAPCLIF(List<Component> CFFEIIKPOPD, bool GPDCMJFDBLI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x4F33EE0", Offset = "0x4F330E0", VA = "0x184F33EE0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x4F33EF0", Offset = "0x4F330F0", VA = "0x184F33EF0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x47481E0", Offset = "0x47473E0", VA = "0x1847481E0", Slot = "8")]
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
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x7C1D990", Offset = "0x7C1CB90", VA = "0x187C1D990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D280", Offset = "0x7C1C480", VA = "0x187C1D280")]
		private void AFLILFPIJAH(GameObject DGGDMAPLALO, bool IKLDNLEDLAC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D3F0", Offset = "0x7C1C5F0", VA = "0x187C1D3F0")]
		public static void AFLILFPIJAH(GameObject DGGDMAPLALO, ToolHierarchyCache CIJAONNPDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D480", Offset = "0x7C1C680", VA = "0x187C1D480")]
		public void EEALFEEFDAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3D9D8C0", Offset = "0x3D9CAC0", VA = "0x183D9D8C0")]
		public void JNJELKMCBEF<T>(Action<T> CJLPDLONOLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3D9D790", Offset = "0x3D9C990", VA = "0x183D9D790")]
		public T EHPKNKLCBAD<T>(bool GPDCMJFDBLI = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3D9D800", Offset = "0x3D9CA00", VA = "0x183D9D800")]
		public FCPAOIAFNJP<T> FHKIPHEBGOK<T>(bool GPDCMJFDBLI = false) where T : class
		{
			return default(FCPAOIAFNJP<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D510", Offset = "0x7C1C710", VA = "0x187C1D510")]
		public List<Component> GAKAAAHPPAP(Type GDHKDBJPDLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D490", Offset = "0x7C1C690", VA = "0x187C1D490", Slot = "4")]
		public bool Equals(ToolHierarchyCache HGCMPGNMMIB, ToolHierarchyCache PIALGICKFLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D890", Offset = "0x7C1CA90", VA = "0x187C1D890", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache KFMNDOMPAMC)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class CJJEHANKCOK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private int POKPPHJAIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int KHOMINGKHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<T> DOMKGFFHOEC;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x46DEF60", Offset = "0x46DE160", VA = "0x1846DEF60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public T DDDBGJONBHF
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x67CF060", Offset = "0x67CE260", VA = "0x1867CF060")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public T CFKMALPBGBM
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x67CEE60", Offset = "0x67CE060", VA = "0x1867CEE60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public T JPCHAIAFBAN
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x67CF240", Offset = "0x67CE440", VA = "0x1867CF240")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x67CF500", Offset = "0x67CE700", VA = "0x1867CF500")]
	public CJJEHANKCOK(int POKPPHJAIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x67CF3B0", Offset = "0x67CE5B0", VA = "0x1867CF3B0")]
	public void LHOMNBOIMGH(T NGHOLMOAHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x67CF4C0", Offset = "0x67CE6C0", VA = "0x1867CF4C0")]
	public void OLKFAGPLGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x67CF130", Offset = "0x67CE330", VA = "0x1867CF130")]
	public void GADBOJMOGNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x67CEF70", Offset = "0x67CE170", VA = "0x1867CEF70")]
	public void DDAGCMJPEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x67CF4B0", Offset = "0x67CE6B0", VA = "0x1867CF4B0")]
	public void OKHDDNCIOMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x67CEEF0", Offset = "0x67CE0F0", VA = "0x1867CEEF0")]
	public List<T> DAEMLGDFLNO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class CIBEOOPMHLB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct KBCHKBEJAOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int OBFEBJHFBGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public T LFLEGEJLLKE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Dictionary<object, KBCHKBEJAOE> MGGGOEHGEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly EqualityComparer<T> GMIGDOCKLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private T MLDIKKECPEE;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public virtual T KFGBIDOLNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xD93950", Offset = "0xD92B50", VA = "0x180D93950", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x67A4F00", Offset = "0x67A4100", VA = "0x1867A4F00", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool KHOHAAPJGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x67A4F70", Offset = "0x67A4170", VA = "0x1867A4F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public object GNIOAJDAALJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA09EE0", Offset = "0xA090E0", VA = "0x180A09EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x67A5150", Offset = "0x67A4350", VA = "0x1867A5150")]
	public bool PAMMCPIPILF(T KJIOHKMJAPE, object CCLFNPCGNED, int JKPJMPOAKPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x67A1D80", Offset = "0x67A0F80", VA = "0x1867A1D80")]
	public bool ADCJALNBKOH(object CCLFNPCGNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x67A2100", Offset = "0x67A1300", VA = "0x1867A2100")]
	public bool FBLKJFCBGPJ(object CCLFNPCGNED, [Out] T KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x67A4FC0", Offset = "0x67A41C0", VA = "0x1867A4FC0")]
	public void OLKFAGPLGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x67A2B70", Offset = "0x67A1D70", VA = "0x1867A2B70")]
	private bool FHCDFBMOPKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x67A59C0", Offset = "0x67A4BC0", VA = "0x1867A59C0")]
	public CIBEOOPMHLB()
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
