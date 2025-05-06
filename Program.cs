//*****************************************************************************
//** 1920. Build Array from Permutation                             leetcode **
//*****************************************************************************

/**
 * Note: The returned array must be malloced, assume caller calls free().
 */
int* buildArray(int* nums, int numsSize, int* returnSize) {
    int* hashbrown = (int*)malloc(numsSize * sizeof(int));
    if (hashbrown == NULL)
    {
        *returnSize = 0;
        return NULL;
    }

    for (int i = 0; i < numsSize; i++)
    {
        hashbrown[i] = nums[nums[i]];
    }

    *returnSize = numsSize;
    return hashbrown;
}