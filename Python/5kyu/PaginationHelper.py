class PaginationHelper:

    # The constructor takes in an array of items and a integer indicating
    # how many items fit within a single page
    def __init__(self, collection, items_per_page):
        self.last_page = 0
        self.items = 0
        self.pages = 0
        self.items_per_page = items_per_page

        if collection != None and len(collection) > 0:
            self.items = len(collection)

            self.last_page = 1 if self.items % items_per_page != 0 else 0
            self.pages = self.items // items_per_page + self.last_page

    # returns the number of items within the entire collection
    def item_count(self):
        return self.items

    # returns the number of pages
    def page_count(self):
        return self.pages

    # returns the number of items on the current page. page_index is zero based
    # this method should return -1 for page_index values that are out of range
    def page_item_count(self, page_index):
        if page_index < 0 or page_index >= self.page_count() or self.item_count() == 0:
            return -1

        if page_index == self.page_count() - 1:
            return self.item_count() % self.items_per_page

        return self.items_per_page

    # determines what page an item is on. Zero based indexes.
    # this method should return -1 for item_index values that are out of range
    def page_index(self, item_index):
        if item_index < 0 or item_index > self.item_count():
            return -1

        return (item_index) // self.items_per_page


collection = range(1, 25)
helper = PaginationHelper(collection, 10)

print(helper.page_count(), '===> 3')
print(helper.page_index(23), '===> 2')
print(helper.item_count(), '===> 24')
